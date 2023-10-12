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
                case 0: return new CondensatePump(blockNum, boiler, order);
                case 1: return new HeatingPump(blockNum, boiler, order);
                case 2: return new FeedPump(blockNum, boiler, order);
                case 3: return new GasCoolingPump(blockNum, boiler, order);
                case 4: return new StartingOilPump(blockNum, boiler, order);
                case 5: return new WorkingOilPump(blockNum, boiler, order);
                case 6: return new EmergencyOilPump(blockNum, boiler, order);
                case 7: return new EmergencySealingOilPump(blockNum, boiler, order);
                case 8: return new BoilerCondensatePump(blockNum, boiler, order);
                case 9: return new HeatingNetworkPump(blockNum, boiler, order);
                case 10: return new FirePump(blockNum, boiler, order);
                default: return null;
            }
        }
        public string FullName() => $"{Name}-{BlockNum}{Boiler}-{Order} КТЦ-{(BlockNum < 5 ? 100 : 200)} бл.{BlockNum}";
        public virtual void InitValues(Control table1)
        {
            values = new Dictionary<string, string>();
            AddValues(table1);
        }
        public virtual void InitValues(Control table1, Control table2)
        {
            InitValues(table1);
            AddValues(table2);
        }
        protected void AddValues(Control table)
        {
            foreach (var tb in table.Controls)
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
