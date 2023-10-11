using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VibrationReporter.Equipment
{
    public abstract class Equipment
    {
        public string Name { get; protected set; }
        public int BlockNum { get; protected set; }
        public string Boiler { get; protected set; }
        public int Order { get; protected set; }
        public int Frequency { get; protected set; }
        public Dictionary<string,string> values { get; protected set; }

        public Equipment(int blockNum, string boiler, int order)
        {
            BlockNum = blockNum;
            Boiler = boiler;
            Order = order;
        }
        public static Equipment InitWithType(int id, int blockNum, string boiler, int order)
        {
            switch (id)
            {
                case 0: return new Test(blockNum, boiler, order); break;
                default: return null;
            }
        }
        public string FullName() => $"{Name}-{BlockNum}{Boiler}-{Order} КТЦ-{(BlockNum < 5 ? 100 : 200)} бл.{BlockNum}";
        public virtual void InitValues(Control table1)
        {
            values = new Dictionary<string, string>();
            foreach (var tb in table1.Controls)
            {
                if (tb is TextBox)
                {
                    var tbContainer = (TextBox)tb;
                    values.Add($"<{tbContainer.Name}>", $"{tbContainer.Text}");
                }
            }
        }
    }
}
