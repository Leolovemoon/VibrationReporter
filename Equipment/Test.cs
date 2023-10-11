using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VibrationReporter.Equipment
{
    public class Test : Equipment
    {
        public Test(int blockNum, string boiler, int order) : base(blockNum, boiler, order)
        {
            Frequency = 1000;
            Name = "КН";
        }
    }
}
