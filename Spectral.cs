using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VibrationReporter
{
    public static class Spectral
    {
        private static FormMain form;
        private static KeyValuePair<string, string> reqList = new KeyValuePair<string, string>("<REQ_LIST>", String.Empty);
        public static void InitMainForm(FormMain form)
        {
            Spectral.form = form;
        }
        public static string GetDisbalanceAnswer(double firstRev) 
        { 
            if(firstRev >= 2)
            {
                reqList = new KeyValuePair<string, string>(reqList.Key,
                    reqList.Value + "Выполнить пуск электродвигателя с расцепленной муфтой, " +
                    "при необходимости выполнить балансировку ротора электродвигателя на станке.^p");
                return "наличие";
            }
            else
            {
                return "отсутствие";
            }
        } 

        public static KeyValuePair<string, string> GetReqTag() => reqList;
        
        public static void AddProblemTags(IDictionary<string, string> tags, bool problem1)
        {
            //Проблема 1
            if (problem1)
            {
                tags.Add("<SPECTRAL_ENGINE_PR_1>", "В спектре вибрации электродвигателя присутствует " +
                        $"множество {form.labelProblem1Even.Text} " +
                        $"оборотной частоте гармоник с уровнем до {form.textBoxSpectralProblem1A.Text} " +
                        $"мм/с ({form.textBoxSpectralProblem1B.Text} Гц), " +
                        "что указывает на наличие развитых дефектов в подшипниковых узлах электродвигателя.");
            }
            else tags.Add("<SPECTRAL_ENGINE_PR_1>", String.Empty);

            //Следующие проблемы
        }
        public static void Clear()
        {
            reqList = new KeyValuePair<string, string>("<REQ_LIST>", String.Empty);
        }

    }
}
