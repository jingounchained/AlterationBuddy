using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Alteration_Buddy
{
    public class Program 
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        string _NAME = "Alteration Buddy";
        string _VERSION = "1.0";
        string _AUTHOR = "Djordje";
        string _DESCRIPTION = "A tool to assist in the design of alterations, as well as to store designs for future use.";

        public System.Windows.Forms.Form _parent;       //Required for plugin
        public MainForm _form;

        public void OpenWindow(Form parent)
        {
            if (_form == null || _form.IsDisposed)
            {
                _form = new MainForm();
                _form.MdiParent = _parent;
            }
            _form.Show();
            _form.BringToFront();
        }

        #region Interface Properties

        public void Initialize()
        {

        }

        public string Name
        {
            get { return _NAME; }
        }

        public string Version
        {
            get { return _VERSION; }
        }

        public string Description
        {
            get { return _DESCRIPTION; }
        }

        public string Author
        {
            get { return _AUTHOR; }
        }

        private bool _enabled = true;
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }
        #endregion
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


        public string ParseText(string text, string window)
        {
            return text;
        }

        public string ParseInput(string text)
        {
            return text;
        }

        public void ParseXML(string xml)
        {

        }

        public void ParentClosing()
        {

        }

    }
}
