using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alteration_Buddy
{
    class Alteration
    {
        public string ShortTap { get; set; }
        public string Tap { get; set; }
        public string Look { get; set; }
        public string Read { get; set; }
        public Alteration(DataRow row)
        {
            ShortTap = row["Column1"].ToString();
            Tap = row["Column2"].ToString();
            Look = row["Column3"].ToString();
            Read = row["Column4"].ToString();
        }

        public Alteration(string alterationString)
        {
            string[] parameters = alterationString.Split('\t');
            ShortTap = parameters[0];
            Tap = parameters[1];
            Look = parameters[2];
            Read = parameters[3];
        }
        public Alteration()
        {

        }

        public override string ToString()
        {
            return ShortTap + "\t" + Tap + "\t" + Look + "\t" + Read;
        }
    }
}
