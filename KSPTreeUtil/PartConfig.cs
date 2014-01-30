using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string rootdir = Properties.Settings.Default.KSPGameData;
            string tmp_field = filename.Replace(rootdir, "");

            FileInfo ff = new FileInfo(filename);
            DirectoryInfo di = ff.Directory;

            string[] ret = Regex.Split(tmp_field, "\\\\");

            return ret[1] + " : " + name + " [ " + title + " ]";
        }
        
    }
}
