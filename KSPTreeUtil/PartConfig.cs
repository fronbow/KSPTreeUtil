using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSPTreeUtil
{
    public class PartConfig
    {
        public string filename { get; set; }
        public string name { get; set; }
        public string TechRequired { get; set; }
        public int entryCost { get; set; }
        public int cost { get; set; }
        public string title { get; set; }
        public string description { get; set; }


        public PartConfig()
        {
            filename = "";
            name = "";
            TechRequired = "";
            entryCost = 0;
            cost = 0;
            title = "";
            description = "";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
