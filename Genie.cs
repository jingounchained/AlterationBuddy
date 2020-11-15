using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alteration_Buddy
{
    sealed class Genie
    {
        private static Genie _instance;

        public static Genie Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Genie();
                }
                return _instance;
            }
        }


        private Genie()
        {
            
        }


        public string GetVariable(string variableName)
        {
            throw new NotImplementedException();
        }

        public void SetVariable(string variableName, string variableValue)
        {
            throw new NotImplementedException();
        }

        public void Echo(string echo)
        {
            throw new NotImplementedException();
        }

        public void SendText(string text)
        {
            throw new NotImplementedException();
        }
    }
}
