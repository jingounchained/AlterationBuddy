using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeniePlugin.Interfaces;
using System.Windows.Forms;

namespace Alteration_Buddy
{
    sealed class Genie
    {
        private static IHost _host;
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

        public Form ParentForm
        {
            get
            {
                return _host.ParentForm;
            }
        }

        private Genie()
        {
            
        }

        public Form GetParentForm()
        {
            return _host.ParentForm;
        }

        public void SetHost(ref IHost host)
        {
            _host = host;
        }

        public string GetVariable(string variableName)
        {
            return _host.get_Variable(variableName);
        }

        public void SetVariable(string variableName, string variableValue)
        {
            _host.SendText("#var " + variableName + " " + variableValue);
        }

        public void Echo(string echo)
        {
            _host.EchoText(echo);
        }

        public void SendText(string text)
        {
            _host.SendText(text);
        }
    }
}
