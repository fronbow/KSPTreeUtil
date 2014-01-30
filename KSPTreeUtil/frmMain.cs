using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace KSPTreeUtil
{
    public partial class frmMain : Form
    {
        List<string> _nodeTreeList = new List<string>();
        List<string> _AvailablePartsList = new List<string>();
        List<string> _UsedPartsList = new List<string>();

        public frmMain()
        {
            InitializeComponent();
            string KSPGameDir = Properties.Settings.Default.KSPDir;

            DataTable nodeTree = new DataTable();
            nodeTree.Columns.Add("name", typeof(string));
            nodeTree.Columns.Add("techID", typeof(string));
            nodeTree.Columns.Add("pos", typeof(string));
            nodeTree.Columns.Add("icon", typeof(string));
            nodeTree.Columns.Add("cost", typeof(float));
            nodeTree.Columns.Add("title", typeof(string));
            nodeTree.Columns.Add("description", typeof(string));
            nodeTree.Columns.Add("anyParent", typeof(string));
            nodeTree.Columns.Add("hideIfEmpty", typeof(string));
            nodeTree.Columns.Add("parents", typeof(string));
            nodeTree.Columns.Add("PARTS", typeof(string)); //thinking how best to do this one!

            ShowData(nodeTree);

            Array sIcon = Properties.Resources.resIcons.Split(new string[] { "\n", "\r\n", "\t", "{", "}" }, StringSplitOptions.None);
            
            tIcon.DataSource = sIcon;

            MenuItemSaveTree.Enabled = false;
            mnuRecentMRU.Enabled = false;

        }

        private void ShowData(DataTable data)
        {
            lbNodeTree.DataSource = data;
            lbNodeTree.DisplayMember = "techID";
            lbNodeTree.ValueMember = "techID";
        }

        public void updateNodeTree(string str)
        {
            _nodeTreeList.Add(str);
        }

        public void updatePartList(string str)
        {

        }

        public void updateUsedParts(string str)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void findKSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOptions frmOptionsNew = new frmOptions();
            frmOptionsNew.Show();

        }

        private void MenuItemOpenTree_Click(object sender, EventArgs e)
        {
            string tempDir = "";

            tempDir = Properties.Settings.Default.KSPSaves;

            if (tempDir == "")
            {
                tempDir = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX) ? Environment.GetEnvironmentVariable("HOME") : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            }

            openFileMain.InitialDirectory = tempDir;
            openFileMain.Filter = "config files (*.cfg)|tree.cfg";
            openFileMain.FileName = "tree.cfg";

            if (openFileMain.ShowDialog() == DialogResult.OK)
            {
                string path = openFileMain.FileName;
                readTree(path);
                
            }
        }


        private void readParts()
        {
            //lbPartList.Items.Clear();

            progressBar.Value = 0;
            string rootdir = Properties.Settings.Default.KSPDir + "\\GameData";

            if (Directory.Exists(rootdir))
            {
                string[] files = Directory.GetFiles(rootdir, "*.cfg", SearchOption.AllDirectories);
                string tmp_field = "";
                Cursor.Current = Cursors.WaitCursor;
                progressBar.Maximum = files.Length;
                progressBar.Step = 1;
                //PartConfig[] tmpParts = new PartConfig[(files.Length)];
                //PartConfig tmpParts = new PartConfig();

                var tmpParts = new List<PartConfig>();


                int counter = 0;
                ListViewItem part = new ListViewItem();

                foreach (string file in files)
                {
                    part.Text = file;
                    FileInfo ff = new FileInfo(file);

                    tmp_field = part.Text.Replace(rootdir, "");
                    tmp_field = tmp_field.Replace(ff.Name, "");

                    //read file and stick in var
                    //--------------------------
                    string theFile = File.ReadAllText(@file);
                    int numLines = File.ReadLines(@file).Count();
                    int counterx = 0;
                    RegexOptions options = RegexOptions.IgnorePatternWhitespace | RegexOptions.Singleline;
                    string pattern = Regex.Escape("{") + ".*?" + Regex.Escape("}");
                    string patterns = "(AUDIO|MODULE|MODEL|EFFECTS|RESOURCE|PROPELLANT).*?" + pattern;      //remove inner patterns from part.cfg

                    string tmpFile = Regex.Replace(theFile, "//.*?\\r\\n", "", options);            //remove comment lines

                    tmpFile = Regex.Replace(tmpFile, "(\\t)", "", options);                      //remove tabs
                    tmpFile = Regex.Replace(tmpFile, patterns, "", options);

                    string[] tparts = Regex.Split(tmpFile, "PART.*?\\{(.*?)\\}", options);
                    //remove non-part entries from parts[]
                    ArrayList parts = new ArrayList();

                    foreach (string p in tparts)
                    {
                        if (p.Contains("name"))
                        {
                            parts.Add(p);
                        }
                    }

                    PartConfig[] fileParts = new PartConfig[parts.Count];

                    foreach (string value in parts)
                    {
                        string[] splitCache = value.Split(new string[] { "\n", "\r", "\t", "{", "}" }, StringSplitOptions.RemoveEmptyEntries);
                        fileParts[counterx] = new PartConfig();
                        foreach (string sc in splitCache)
                        {
                            string[] vals = Regex.Split(sc, "=", options);
                            switch (vals[0].Trim())
                            {
                                case "name":
                                    fileParts[counterx].name = vals[1].Trim();
                                    break;
                                case "TechRequired":
                                    fileParts[counterx].TechRequired = vals[1].Trim();
                                    break;
                                case "entryCost":
                                    fileParts[counterx].entryCost = Convert.ToInt32(vals[1].Trim());
                                    break;
                                case "cost":
                                    fileParts[counterx].cost = Convert.ToInt32(vals[1].Trim());
                                    break;
                                case "title":
                                    fileParts[counterx].title = vals[1].Trim();
                                    break;
                                case "description":
                                    fileParts[counterx].description = vals[1].Trim();
                                    break;
                            }
                        }
                        fileParts[counterx].filename = ff.FullName;
                        //lbPartList.Items.Add(fileParts[counter].ToString());
                        if (fileParts[counterx].title != "")
                        {
                            //tmpParts[counter] = fileParts[counterx];
                            tmpParts.Add(fileParts[counterx]);
                        }
                        
                        counterx++;
                    }
                    //--------------------------

                    progressBar.PerformStep();
                    counter++;
                }
                

                lbPartList.DataSource = tmpParts.ToList();
                lbPartList.Refresh();

                Cursor.Current = Cursors.Default;
                progressBar.Value = 0;
            }
            else
            {
                MessageBox.Show("Please specify the KSP directory in the options menu");
            }

            

        }

        private void readTree(string path)
        {
            string file = File.ReadAllText(@path);
            int numLines = File.ReadLines(@path).Count();
            string[] nodes = Regex.Split(file, "\r\n\t}\r\n}");
            int size = nodes.Length;
			string[] nodeBlocks = new string[size];
			
            for (int i = 0; i < size; i++)
            {
                nodeBlocks[i] = nodes[i] + "\t}\r\n}";
            }
            
            int sizeN = nodeBlocks.Count();
            
            //nodeBlocks now contains all the nodes from the tree interspersed with \r\n's
            nodeTree[] tmpTree = new nodeTree[sizeN - 1];
            int counter = 0;
            
            foreach(string value in nodeBlocks)
            {
                if (counter == (sizeN - 1))
                {
                    break;
                }

            	tmpTree[counter] = new nodeTree();
            	string[] splitCache = value.Split(new string[] {"\n", "\r\n", "\t", "{", "}"}, StringSplitOptions.RemoveEmptyEntries);
            	string[] tmpPartsCache = value.Split(new string[] {"PARTS"}, StringSplitOptions.RemoveEmptyEntries);

            	foreach (string sc in splitCache) {
            		if (sc != "NODE") {
            			string[] parts = Regex.Split(sc, "=");
            			
            			switch (parts[0].Trim()) {
            				case "name":
            					tmpTree[counter].name = parts[1].Trim();
            					
            					break;
            				case "techID":
            					tmpTree[counter].TechID = parts[1].Trim();
            					
            					break;
            				case "pos":
            					tmpTree[counter].Pos = parts[1].Trim();
            					
            					break;
            				case "icon":
            					tmpTree[counter].Icon = parts[1].Trim();
            					
            					break;
            				case "cost":
            					tmpTree[counter].Cost = Convert.ToInt32( parts[1].Trim() );
            					
            					break;
            				case "title":
            					tmpTree[counter].Title = parts[1].Trim();
            					
            					break;
            				case "description":
            					tmpTree[counter].Description = parts[1].Trim();
            					
            					break;
            				case "anyParent":
            					tmpTree[counter].AnyParent = Convert.ToBoolean( parts[1].Trim());
            					
            					break;
            				case "hideIfEmpty":
            					tmpTree[counter].HideIfEmpty = Convert.ToBoolean(parts[1].Trim());
            					
            					break;
            				case "parents":
            					tmpTree[counter].Parents = parts[1].Trim();
            					
            					break;
            			}
            			
            			if (sc == "PARTS") {
            				string[] partsCache = tmpPartsCache[1].Split(new string[] {"\n", "\r\n", "\t", "{", "}"}, StringSplitOptions.RemoveEmptyEntries);
            				foreach (string ss in partsCache) {
            					string[] pparts = Regex.Split(ss, "=");
            					
                                tmpTree[counter].Parts.Add(pparts[1].Trim());
            				}
            				
            				break;
            			}
            		}
            		
            	}
                
            	counter += 1;
            }
            lbNodeTree.DataSource = tmpTree.ToList();
            
        }

        private void importGameDataMnu_Click(object sender, EventArgs e)
        {
            

            readParts();

            
        }

        private void refreshAvailableParts()
        {

        }

        private void refreshConnectedParts()
        {

        }


        void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        	// TODO: Implement ToolStripMenuItem1_Click
        }

        private void openFileMain_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void lbNodeTree_MouseClick(object sender, MouseEventArgs e)
        {
            ListBox lv = sender as ListBox;
            int item = 0;

            if (lv != null)
            {
                item = lv.SelectedIndex;
            }
            //change the data in the middle panel
            if (lbNodeTree.SelectedItem != null)
            {
                List<nodeTree> sel = new List<nodeTree>();

                object selected = lbNodeTree.SelectedItem;

                System.Reflection.MemberInfo inf = typeof(nodeTree);
                //object[] attributes;
                //attributes = inf.GetCustomAttributes(typeof(nodeTree), false);
                var current = lbNodeTree.SelectedItem as nodeTree;

                tNodeName.Text = current.name;
                tTechID.Text = current.TechID;
                tPos.Text = current.Pos;
                tIcon.Text = current.Icon;
                tCost.Text = current.Cost.ToString();
                tTitle.Text = current.Title;
                tDesc.Text = current.Description;
                tAnyParent.Text = current.AnyParent.ToString();         // *
                tHideIfEmpty.Text = current.HideIfEmpty.ToString();     // *
                
                List<String> tmpParents = new List<string>();
                tParents.Items.Clear();
                tmpParents.Add(current.Parents);
                tParents.Items.Add(current.Parents);

                //iterate thru parts list
                List<String> tmpParts = new List<String>();
                tPartsList.Items.Clear();
                foreach(string part in current.Parts) {
                    tmpParts.Add(part);
                    tPartsList.Items.Add(part);
                }
                
                

                
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox frmAbout = new AboutBox();
            frmAbout.Show();
        }
    }


}
