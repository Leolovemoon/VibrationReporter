using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace VibrationReporter
{
    public class DocWorker
    {
        private FileInfo layoutfileInfo;

        public DocWorker(string layoutFileName)
        {
            if (File.Exists(layoutFileName))
            {
                layoutfileInfo = new FileInfo(layoutFileName);
            }
            else
            {
                throw new ArgumentException($"Шаблона \"{layoutFileName}\" не существует");
            }
        }

        public void InsertItems(Dictionary<string, string> items)
        {
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                var file = layoutfileInfo.FullName;
                var missing = Type.Missing;

                app.Documents.Open(file);

                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    var wrap = Word.WdFindWrap.wdFindContinue;
                    var replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing,
                        Replace: replace);
                }

                var newFileName = Path.Combine(layoutfileInfo.DirectoryName, DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "_report");
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();
                app.Quit();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            finally
            {
                if (app != null)
                {
                    app.Quit();
                }
            }
        }
    }
}
