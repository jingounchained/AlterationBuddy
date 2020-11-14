using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenericParsing;

namespace Alteration_Buddy
{
    public partial class MainForm : Form
    {
        private string _pluginPath;
        private string _filePath;
        private const int MAX_TAP = 80;
        private const int MAX_LOOK = 500;
        private const int MAX_READ_WORDS = 10;
        private const int MAX_READ_CHARACTERS = 50;

        private int LoadedFromIndex = 0;
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
#if DEBUG
            _pluginPath = Directory.GetCurrentDirectory();
#else
            _pluginPath = Genie.Instance.GetVariable("PluginPath");
#endif
            _filePath = _pluginPath + "\\alterations.csv";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAlterationList();
        }

        private void LoadAlterationList()
        {
            LoadedFromIndex = 0;
            lstAlterations.Items.Clear();
            lstAlterations.Items.Add("New...");
             
            if(File.Exists(_filePath))
            {
                DataSet AlterationFile = new DataSet();
                using (GenericParserAdapter parser = new GenericParserAdapter(_filePath))
                {
                    parser.ColumnDelimiter = '\t';
                    parser.FirstRowHasHeader = false;
                    AlterationFile = parser.GetDataSet();
                }
                foreach(DataRow row in AlterationFile.Tables[0].Rows)
                {
                    lstAlterations.Items.Add(new Alteration(row));
                }
            }
        }

        private void SaveAlterationList()
        {
            using(StreamWriter writer = new StreamWriter(_filePath))
            {
                for (int i = 1; i < lstAlterations.Items.Count; i++) //skip the first entry, which should always be "New..."
                {
                    writer.WriteLine(lstAlterations.Items[i]);
                }
            }

        }
        private void txtShortTap_TextChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void txtTap_TextChanged(object sender, EventArgs e)
        {
            int remainder = MAX_TAP - txtTap.Text.Length;
            countTap.Text = remainder.ToString() + " characters remaining.";
            if(remainder < 1)
            {
                countTap.ForeColor = Color.Red;
            }
            else
            {
                countTap.ForeColor = Color.Black;
            }
            UpdateResult();
        }

        private void txtLook_TextChanged(object sender, EventArgs e)
        {
            int remainder = MAX_LOOK - txtLook.Text.Length;
            countLook.Text = remainder.ToString() + " characters remaining.";
            if (remainder < 1)
            {
                countLook.ForeColor = Color.Red;
            }
            else
            {
                countLook.ForeColor = Color.Black;
            }
            UpdateResult();
        }

        private void txtRead_TextChanged(object sender, EventArgs e)
        {
            int remainingWords = MAX_READ_WORDS - txtRead.Text.Split(' ').Length;
            int remainingChars = MAX_READ_CHARACTERS - txtRead.Text.Length;
            countRead.Text = remainingWords + " words and " + remainingChars + " characters remaining.";
            if(remainingChars < 1 || remainingWords < 1)
            {
                countRead.ForeColor = Color.Red;
            }
            else
            {
                countRead.ForeColor = Color.Black;
            }
            UpdateResult();
        }

        private void UpdateResult()
        {
            txtResult.Text = "";
            if (txtShortTap.Text.Length > 0) txtResult.Text += "Short Tap: " + txtShortTap.Text;

            if (txtResult.Text.Length > 0 && txtTap.Text.Length > 0) txtResult.Text += " \\ ";
            if (txtTap.Text.Length > 0) txtResult.Text += "Tap: " + txtTap.Text;

            if (txtResult.Text.Length > 0 && txtLook.Text.Length > 0) txtResult.Text += " \\ ";
            if (txtLook.Text.Length > 0) txtResult.Text += "Look: " + txtLook.Text;

            if (txtResult.Text.Length > 0 && txtRead.Text.Length > 0) txtResult.Text += " \\ ";
            if (txtRead.Text.Length > 0) txtResult.Text += "Read: " + txtRead.Text;

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alteration selection = new Alteration();
            int i = lstAlterations.SelectedIndex;
            if (i < 1)
            {
                selection = new Alteration();
                LoadedFromIndex = 0;
            }
            else
            {
                selection = new Alteration(lstAlterations.Items[i].ToString());
                LoadedFromIndex = i;
            }
            txtShortTap.Text = selection.ShortTap;
            txtTap.Text = selection.Tap;
            txtLook.Text = selection.Look;
            txtRead.Text = selection.Read;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alteration selection = new Alteration();
            int i = lstAlterations.SelectedIndex;
            if(i == -1)
            {
                MessageBox.Show("Please select an item to delete.","No Selection");
                return;
            }
            if (i == 0)
            {
                return;
            }
            else
            {
                selection = new Alteration(lstAlterations.Items[i].ToString());
            }
            DialogResult response = MessageBox.Show("Do you really wish to delete your design for [" + selection.Tap + "]?", "Confirm Delete", MessageBoxButtons.YesNoCancel);
            if(response == DialogResult.Yes)
            {
                lstAlterations.Items.RemoveAt(i);
                SaveAlterationList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Alteration alterationToSave = new Alteration();
            alterationToSave.ShortTap = txtShortTap.Text;
            alterationToSave.Tap = txtTap.Text;
            alterationToSave.Look = txtLook.Text;
            alterationToSave.Read = txtRead.Text;
            if (LoadedFromIndex == 0)
            {
                lstAlterations.Items.Add(alterationToSave);
                LoadedFromIndex = lstAlterations.Items.Count - 1;
            }
            else
            {
                lstAlterations.Items[LoadedFromIndex] = alterationToSave;
            }
            SaveAlterationList();
        }

        private void lstAlterations_DoubleClick(object sender, EventArgs e)
        {
            loadToolStripMenuItem_Click(sender, e);
        }

        private void lnkElanthipedia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://elanthipedia.play.net/Alteration");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the default browser.");
            }
        }

        private void lnkWitchsWorkshop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://sites.google.com/site/thewitchsworkshop/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the default browser.");
            }
        }

        private void lnkDRServiceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://drservice.info");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the default browser.");
            }
        }

        private void lstAlterations_MouseDown(object sender, MouseEventArgs e)
        {
            lstAlterations.SelectedIndex = lstAlterations.IndexFromPoint(e.X, e.Y);
        }
    }
}
