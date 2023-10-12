using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VibrationReporter.Equipment
{
    public class CondensatePump : Equipment
    {
        public CondensatePump(int blockNum, string boiler, int order) : base(blockNum, boiler, order)
        {
            Frequency = 1000;
            Name = "КН";
        }
    }
    public class HeatingPump : Equipment
    {
        public HeatingPump(int blockNum, string boiler, int order) : base(blockNum, boiler, order)
        {
            Frequency = 1500;
            Name = "НПНД";
        }
    }
    public class FeedPump : Equipment
    {
        public FeedPump(int blockNum, string boiler, int order) : base(blockNum, boiler, order)
        {
            Frequency = 3000;
            Name = "ПЭН";
        }
    }
    public class GasCoolingPump : Equipment
    {
        public GasCoolingPump(int blockNum, string boiler, int order) : base(blockNum, boiler, order)
        {
            Frequency = 1000;
            Name = "НГО";
        }
    }
    public class StartingOilPump : Equipment
    {
        public StartingOilPump(int blockNum, string boiler, int order) : base(blockNum, boiler, order)
        {
            Frequency = 1000;
            Name = "ПМН";
        }
    }
    public class WorkingOilPump : Equipment
    {
        public WorkingOilPump(int blockNum, string boiler, int order) : base(blockNum, boiler, order)
        {
            Frequency = 1500;
            Name = "РМН";
        }
    }
    public class EmergencyOilPump : Equipment
    {
        public EmergencyOilPump(int blockNum, string boiler, int order) : base(blockNum, boiler, order)
        {
            Frequency = 1500;
            Name = "АМН";
        }
    }
    public class EmergencySealingOilPump : Equipment
    {
        public EmergencySealingOilPump(int blockNum, string boiler, int order) : base(blockNum, boiler, order)
        {
            Frequency = 3000;
            Name = "АМНУ";
        }
    }
    public class BoilerCondensatePump : Equipment
    {
        public BoilerCondensatePump(int blockNum, string boiler, int order) : base(blockNum, boiler, order)
        {
            Frequency = 1500;
            Name = "КНБ";
        }
    }
    public class HeatingNetworkPump : Equipment
    {
        public HeatingNetworkPump(int blockNum, string boiler, int order) : base(blockNum, boiler, order)
        {
            Frequency = 1500;
            Name = "СНТ";
        }
    }
    public class FirePump : Equipment
    {
        public FirePump(int blockNum, string boiler, int order) : base(blockNum, boiler, order)
        {
            Frequency = 1500;
            Name = "НПЖ";
        }
    }

}
