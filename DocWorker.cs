using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Windows.Forms;

namespace VibrationReporter
{
    public class DocWorker
    {
        private FileInfo layoutfileInfo;
        public static Dictionary<string, string> tags { get; private set; }
        public void InitializeTags(Equipment.Equipment equipment)
        {
            tags = new Dictionary<string, string>()
            {
                {"<EQUIP_FULLNAME>", equipment.FullName()},
                {"<DATE_YEAR>", DateTime.Now.ToString("yyyy")},
                {"<DATE_FULL>", DateTime.Now.ToString("dd.MM.yyyy")},
                {"<EQUIP_FREQ>", equipment.Frequency.ToString()},
                {"<EQUIP_NAME>", equipment.Name},
                {"<BLOCK_NUM>", equipment.BlockNum.ToString()},
                {"<BOILER>", equipment.Boiler},
                {"<ORDER>", equipment.Order.ToString()}
            };

            foreach (var el in equipment.values)
            {
                tags.Add($"{el.Key}", $"{el.Value}");
            }
        }

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

        public void InsertItems()
        {
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                var file = layoutfileInfo.FullName;
                var missing = Type.Missing;

                app.Documents.Open(file);

                foreach (var item in tags)
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
