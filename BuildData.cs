using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineProgram
{
    public class BuildData
    {
        public string Build { get; set; }
        public string PcID { get; set; }  
        public int Completed { get; set; }
        public double AverageTime { get; set; }
        public double BestTime { get; set; }
        public double TotalTime { get; set; }  // Total time for the build
        public double TargetTime { get; set; }//target time
    }


}

