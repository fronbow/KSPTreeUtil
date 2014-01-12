using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSPTreeUtil
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            string filepath = Properties.Settings.Default.KSPDir;

            if (!Directory.Exists(filepath))
            {
                tbKSPDir.Text = "";
                tbGameData.Text = "";
                tbSavesDir.Text = "";

            }
            else
            {
                tbKSPDir.Text = Properties.Settings.Default.KSPDir;
                tbGameData.Text = Properties.Settings.Default.KSPGameData;
                tbSavesDir.Text = Properties.Settings.Default.KSPSaves;

            }
        }

        private void btnOptionsSave_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbKSPDir.Text))
            {
                Properties.Settings.Default.KSPDir = tbKSPDir.Text;
                Properties.Settings.Default.KSPGameData = tbGameData.Text;
                Properties.Settings.Default.KSPSaves = tbSavesDir.Text;

                Properties.Settings.Default.Save();
            }

            this.Close();
        }

        private void btnOptionsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindKSP_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(tbKSPDir.Text))
            {
                dlgFindKSP.SelectedPath = tbKSPDir.Text;
            }
            else
            {
                string homePath = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX) ? Environment.GetEnvironmentVariable("HOME") : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");

                dlgFindKSP.SelectedPath = homePath;
            }

            dlgFindKSP.ShowDialog();
            tbKSPDir.Text = dlgFindKSP.SelectedPath;
            tbGameData.Text = tbKSPDir.Text + "\\GameData";
            tbSavesDir.Text = tbKSPDir.Text + "\\saves";

            Properties.Settings.Default.KSPDir = tbKSPDir.Text;
            Properties.Settings.Default.KSPGameData = tbGameData.Text;
            Properties.Settings.Default.KSPSaves = tbSavesDir.Text;
        }

        private void btnImportGameData_Click(object sender, EventArgs e)
        {
            //traverse the GameData folder and collect all the part.cfg files
            //need: name, TechRequired, cost, category, subcategory, title

            Form _parent = new frmMain();
            
            string[] files = Directory.GetFiles(tbGameData.Text, "part.cfg", SearchOption.AllDirectories);
            
            Cursor.Current = Cursors.WaitCursor;

            ListViewItem part = new ListViewItem();

            foreach (string file in files)
            {
                //Console.WriteLine(file);
                part.Text = file;

            }
            
            
            Cursor.Current = Cursors.Default;

        }
    }
}
