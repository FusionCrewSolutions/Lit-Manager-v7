using System;
using System.Windows.Forms;
using System.Drawing;



namespace FCS_Lit_Manager
{
    public partial class Form1 : Form
    {
        string _title = "FCS Lit Manager 7";
        int numOfFolders = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = _title;
            AddNewFolderPage();
        }

        public void setTspStsLblTxt(string text)
        {
            tspStsLbl.Text = text;
        }

        public void OpenPDF(string path)
        {
            pdfViewer.LoadFile(path);
        }

        public void updateTabPageOnBrowse(string folderPath)
        {
            for(int x=0; x<tabFolders.TabCount;x++)
            {
                if (tabFolders.SelectedIndex == x)
                {
                    string[] folder = folderPath.Split('\\');
                    string folderName = folder[folder.Length - 1];
                    tabFolders.TabPages[x].Text = folderName;
                    tabFolders.TabPages[x].Tag = folderPath;
                    tabFolders.TabPages[x].ToolTipText = folderPath;
                }  
            }
        }


        //Add new folder page-----------------------------------------------------
        private void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string key = (numOfFolders++).ToString();
            tabFolders.TabPages.Add(key, "x     new");
            tabFolders.TabPages[key].Controls.Add((new FormSidebar()).getNewFolderPage());
        }

        private void AddNewFolderPage()
        {
            try
            {
                string key = (numOfFolders++).ToString();
                string[] lastFolders = FCS_Lit_Manager.Properties.Settings.Default.LastFolder.Split(',');

                if (lastFolders.Length <= 1)
                {
                    tabFolders.TabPages.Add(key, "x     new");
                    tabFolders.TabPages[key].Controls.Add((new FormSidebar()).getNewFolderPage());
                }
                else
                {
                    for (int x = 0; x < lastFolders.Length; x++)
                    {
                        if (lastFolders[x] != "")
                        {
                            FormSidebar sidebar = new FormSidebar();
                            sidebar._folderPath = lastFolders[x];

                            string[] folder = lastFolders[x].Split('\\');
                            string folderName = folder[folder.Length - 1];

                            key = (numOfFolders++).ToString();

                            tabFolders.TabPages.Add(key, "x     " + folderName);
                            tabFolders.TabPages[key].Controls.Add(sidebar.getNewFolderPage());
                            tabFolders.TabPages[key].Tag = lastFolders[x];
                            tabFolders.TabPages[key].ToolTipText = lastFolders[x];

                            sidebar.LoadFolder();
                        }
                    }
                }
            }
            catch (Exception er)
            {
                setTspStsLblTxt("Error while loading...");
            }
        }




        //Close folder page-------------------------------------------------------
        //Get the clicked tab page for closing or dragging
        private TabPage TabAt(Point position)
        {
            int count = tabFolders.TabCount;

            for (int i = 0; i < count; i++)
            {
                if (tabFolders.GetTabRect(i).Contains(position))
                {
                    return tabFolders.TabPages[i];
                }
            }

            return null;
        }

        private void tabFolders_MouseDown(object sender, MouseEventArgs e)
        {
            TabPage _dragTabPage = TabAt(e.Location);

            for (int i = 0; i < this.tabFolders.TabPages.Count; i++)
            {
                Rectangle r = tabFolders.GetTabRect(i);
                Rectangle closeButton = new Rectangle(r.Left, r.Top, 16, 20);//Getting the position of the "x" mark.

                if (closeButton.Contains(e.Location))
                {
                    this.tabFolders.SelectedIndex = i;
                    this.tabFolders.TabPages.Remove(_dragTabPage);
                    updateCurFolderListOnClose();
                    break;
                }
            }//End of FOR

            if (tabFolders.TabCount == 0)
            {
                AddNewFolderPage();
            }
        }

        private void updateCurFolderListOnClose()
        {
            string curFolders = "";

            for (int x = 0; x < tabFolders.TabCount; x++)
            {
                if (tabFolders.TabPages[x].Tag != null && tabFolders.TabPages[x].Tag.ToString() != "")
                {
                    curFolders = curFolders + "," + tabFolders.TabPages[x].Tag.ToString();
                }
            }

            FCS_Lit_Manager.Properties.Settings.Default.LastFolder = curFolders;
            FCS_Lit_Manager.Properties.Settings.Default.Save();
        }
    }
}
