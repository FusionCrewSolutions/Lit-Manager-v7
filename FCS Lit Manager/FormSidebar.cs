using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace FCS_Lit_Manager
{
    public partial class FormSidebar : Form
    {
        LitManager _lm;
        public string _folderPath = "";
        bool _isTagLoading = false;
        string _tagtoEdit = "";


        public FormSidebar()
        {
            InitializeComponent();

            try
            {
                dgvFiles.Sort(dgvFiles.Columns[1], ListSortDirection.Ascending);
                _lm = new LitManager();
            }
            catch (Exception er)
            {
                setTspStsLblTxt("Error while loading...");
            }
        }



        private void setTspStsLblTxt(string text)
        {
            ((FCS_Lit_Manager.Form1)this.SplitContainer2.FindForm()).setTspStsLblTxt(text);
        }

        private void FormSidebar_Load(object sender, EventArgs e)
        {

        }

        public Control getNewFolderPage()
        {
            return this.SplitContainer2;
        }




        //--FOLDER n FILES....................................................................................
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean isFolderExist = false;

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    _folderPath = folderBrowserDialog1.SelectedPath;

                    string[] curFolders = FCS_Lit_Manager.Properties.Settings.Default.LastFolder.Split(',');

                    for(int x=0; x< curFolders.Length;x++)
                    {
                        if(curFolders[x]==_folderPath)
                        {
                            isFolderExist = true;
                        }
                    }

                    if (!isFolderExist)
                    {
                        FCS_Lit_Manager.Properties.Settings.Default.LastFolder = FCS_Lit_Manager.Properties.Settings.Default.LastFolder + "," + _folderPath;
                        FCS_Lit_Manager.Properties.Settings.Default.Save();

                        LoadFolder();
                    }
                    else
                    {
                        setTspStsLblTxt("Folder is already opened.");
                    }
                }
            }
            catch (Exception er)
            {
                setTspStsLblTxt("Error while loading files...");
            }
        }

        public void LoadFolder()
        {

            if (_folderPath != "init" || _folderPath != "")
            {
                string[] folder = _folderPath.Split('\\');
                txtFolder.Text = folder[folder.Length - 1];
                toolTipFolder.SetToolTip(txtFolder, _folderPath);

                _isTagLoading = true;
                _lm.loadFolder(_folderPath, dgvFiles, lstAllTags);
                _isTagLoading = false;

                ((FCS_Lit_Manager.Form1)this.SplitContainer2.FindForm()).updateTabPageOnBrowse(_folderPath);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _isTagLoading = true;
            _lm.loadFolder(_folderPath, dgvFiles, lstAllTags);
            _isTagLoading = false;
        }




        //SET / UNSET TAG TO FILE----------------------------------
        private void btnSetTag_Click(object sender, EventArgs e)
        {
            try
            {
                string tag = "";

                if (lstAllTags.SelectedItems.Count > 0)
                {
                    tag = lstAllTags.SelectedItems[0].Text;
                }
                else
                {
                    setTspStsLblTxt("Select tag to set...");
                    return;
                }


                //--------------
                if (_lm.setTag(tag, dgvFiles.SelectedRows[0].Cells[1].Value.ToString()))
                {
                    dgvFiles.SelectedRows[0].Cells[2].Value = _lm.loadTagsOfFile(dgvFiles.SelectedRows[0].Cells[1].Value.ToString());
                    setTspStsLblTxt("Tag was set successfully...");
                }
                else
                {
                    setTspStsLblTxt("Error while setting tag...");
                }
            }
            catch (Exception er)
            {
                setTspStsLblTxt("Error while trying setting tag...");
            }
        }

        private void btnUnsetTag_Click(object sender, EventArgs e)
        {
            try
            {
                string tag = "";

                if (lstAllTags.SelectedItems.Count > 0)
                {
                    tag = lstAllTags.SelectedItems[0].Text;
                }
                else
                {
                    setTspStsLblTxt("Select tag to un-set...");
                    return;
                }


                //----------------------
                if (_lm.unsetTag(tag, dgvFiles.SelectedRows[0].Cells[1].Value.ToString()))
                {
                    dgvFiles.SelectedRows[0].Cells[2].Value = _lm.loadTagsOfFile(dgvFiles.SelectedRows[0].Cells[1].Value.ToString());
                    setTspStsLblTxt("Tag was unset successfully...");
                }
                else
                {
                    setTspStsLblTxt("Error while unsetting the tag...");
                }
            }
            catch (Exception er)
            {
                setTspStsLblTxt("Error while trying unsetting tag...");
            }
        }




        //CHANGE AND / OR OPERATOR---------------------------------------
        private void rdoAndOr_CheckedChanged(object sender, EventArgs e)
        {
            if (lstAllTags.CheckedItems.Count > 0)
            { loadFiles(); }
        }



        //LOADING------------------
        private void loadFiles()
        {
            setTspStsLblTxt("Loading...");

            int selectedRowIndex = 0;
            string selectedRowFileName = "";
            DataGridViewColumn sortCol = dgvFiles.SortedColumn;
            ListSortDirection sortDirection = ListSortDirection.Ascending;

            if (dgvFiles.SelectedRows.Count > 0)
            {
                selectedRowIndex = dgvFiles.SelectedRows[0].Index;
                selectedRowFileName = dgvFiles.SelectedRows[0].Cells[1].Value.ToString();
                sortCol = dgvFiles.SortedColumn;


                if (dgvFiles.SortOrder == System.Windows.Forms.SortOrder.Ascending)
                {
                    sortDirection = ListSortDirection.Ascending;
                }
                else
                {
                    sortDirection = ListSortDirection.Descending;
                }
            }

            dgvFiles.Rows.Clear();


            if (lstAllTags.CheckedItems.Count == 0)
            {
                _lm.loadAllFiles(dgvFiles);
            }
            else
            {
                string[] tags = new string[lstAllTags.CheckedItems.Count];

                int count = 0;
                foreach (ListViewItem item in lstAllTags.CheckedItems)
                { tags[count] = item.Text; count++; }


                string mode = "";
                if (rdoAnd.Checked) { mode = "AND"; } else { mode = "OR"; }

                _lm.loadFilteredFiles(dgvFiles, tags, mode);
            }


            _lm.loadTagsOfFiles(dgvFiles);

            //----------------------------
            dgvFiles.Sort(sortCol, sortDirection);

            //Find the selected row
            for (int x = 0; x < dgvFiles.Rows.Count; x++)
            {
                if (dgvFiles.Rows[x].Cells[1].Value.ToString() == selectedRowFileName)
                {
                    selectedRowIndex = x;
                    break;
                }
            }

            if (dgvFiles.Rows.Count > 0)
            {
                dgvFiles[0, selectedRowIndex].Selected = true;
                dgvFiles.FirstDisplayedScrollingRowIndex = selectedRowIndex;
            }

            setTspStsLblTxt("Loaded.");
        }



        //OPEN FILE FOR READ-----------------------------------------
        private void dgvFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setTspStsLblTxt("Loading....");

                if (e.RowIndex < 0)
                {
                    return;
                }

                //--------------------------------------------------------
                if (dgvFiles["File", e.RowIndex].Value.ToString() != "")
                {

                    string path = _folderPath + "\\" + dgvFiles["File", e.RowIndex].Value.ToString();
                    ((FCS_Lit_Manager.Form1)this.SplitContainer2.FindForm()).OpenPDF(path);

                    setTspStsLblTxt("File loaded succcessfully...");
                }

                if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    System.Diagnostics.Process.Start(@_folderPath + "\\" + dgvFiles["File", e.RowIndex].Value.ToString());

                    setTspStsLblTxt("File opened succcessfully...");
                }
            }
            catch (Exception er)
            {
                setTspStsLblTxt("Error while loading the file...");
            }
        }


        //SERCH FOR FILE-------------------------------------------
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                dgvFiles.Rows.OfType<DataGridViewRow>().ToList().ForEach(row => { row.Visible = true; });
                return;
            }

            for (int x = 0; x < dgvFiles.Rows.Count; x++)
            {
                if (dgvFiles.Rows[x].Cells[1].Value.ToString().ToUpper().Contains(txtSearch.Text.Trim().ToUpper()))
                {
                    dgvFiles.Rows[x].Visible = true;
                }
                else
                {
                    dgvFiles.Rows[x].Visible = false;
                }
            }
        }




        //--TAGS...................................................................................................
        private void btnAddTag_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddTag.Text.Trim() == "")
                {
                    setTspStsLblTxt("Enter tag to add...");
                    return;
                }

                ListViewItem item = lstAllTags.FindItemWithText(txtAddTag.Text.Trim());

                if (item != null && lstAllTags.Items.Contains(item))
                {
                    setTspStsLblTxt("Tag already exists...");
                    return;
                }


                //-----------------------------
                if (_lm.saveTag(txtAddTag.Text.Trim()))
                {
                    lstAllTags.Items.Add(txtAddTag.Text);
                    setTspStsLblTxt("Tag is added...");
                    txtAddTag.Text = "";
                }
                else
                {
                    setTspStsLblTxt("Error while adding tag...");
                }
            }
            catch (Exception er)
            {
                setTspStsLblTxt("Error while adding tag...");
            }
        }

        private void btnRemoveTag_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAllTags.SelectedItems.Count > 0)
                {
                    if (_lm.deleteTag(lstAllTags.SelectedItems[0].Text))
                    {
                        lstAllTags.SelectedItems[0].Remove();
                        setTspStsLblTxt("Tag is removed...");
                    }
                    else
                    {
                        setTspStsLblTxt("Error while removing tag...");
                    }
                }
            }
            catch (Exception er)
            {
                setTspStsLblTxt("Error while removing tag...");
            }
        }


        //CHECK TAG
        private void lstAllTags_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!_isTagLoading)
            {
                loadFiles();
            }
        }

        private void lstAllTags_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            try
            {
                _tagtoEdit = lstAllTags.SelectedItems[0].Text.ToString();
            }
            catch (Exception er)
            {
                setTspStsLblTxt("Error while editing...");
            }
        }

        private void lstAllTags_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            try
            {
                if (_tagtoEdit == e.Label.ToString())
                {
                    return;
                }



                ListViewItem item = lstAllTags.FindItemWithText(e.Label.ToString().Trim());

                if (item != null && lstAllTags.Items.Contains(item))
                {
                    e.CancelEdit = true;
                    setTspStsLblTxt("Tag already exists...");
                    return;
                }




                if (_lm.updateTag(_tagtoEdit, e.Label.ToString().Trim()))
                {
                    setTspStsLblTxt("Updated successfully...");
                }
                else
                {
                    setTspStsLblTxt("Error while updating...");
                }
            }
            catch (Exception er)
            {
                return;
            }
        }
    }



    //==LIT MANAGER CLASS==================================================================================================
    class LitManager
    {
        string _folder = "";
        SqlConnection _con;
        SqlCommand _cmd;
        SqlDataReader _reader;


        public LitManager()
        {
            _con = new SqlConnection();
            _cmd = new SqlCommand();
        }


        //TAGS---------------------------------------------------------------------------------
        public void loadAllTags(ListView lstAllTags)
        {
            try
            {
                lstAllTags.Items.Clear();

                _con.Open();
                _cmd.CommandText = "select tagName from LitManTags order by tagName";
                _cmd.Connection = _con;

                _reader = _cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(_reader);

                foreach (DataRow row in dt.Rows)
                {
                    lstAllTags.Items.Add(row[0].ToString());
                }

                _con.Close();
            }
            catch (Exception er)
            {
                _con.Close();
            }
        }

        public bool saveTag(string tagName)
        {
            try
            {
                _con.Open();
                _cmd.CommandText = "INSERT INTO LitManTags(TagName) VALUES ('" + tagName + "')";
                _cmd.Connection = _con;
                _cmd.ExecuteNonQuery();
                _con.Close();

                return true;
            }
            catch (Exception er)
            {
                _con.Close();
                return false;
            }
        }

        public bool updateTag(string oldName, string newName)
        {
            try
            {
                _con.Open();
                _cmd.Connection = _con;

                _cmd.CommandText = "UPDATE LitManTags SET TagName = '" + newName +
                    "' WHERE (TagName = '" + oldName + "'); ";
                _cmd.ExecuteNonQuery();

                _cmd.CommandText = "UPDATE FilesTags SET TagName = '" + newName +
                    "' WHERE (TagName = '" + oldName + "'); ";
                _cmd.ExecuteNonQuery();


                _con.Close();

                return true;
            }
            catch (Exception er)
            {
                _con.Close();
                return false;
            }
        }

        public bool deleteTag(string tagName)
        {
            try
            {
                _con.Open();
                _cmd.CommandText = "delete from LitManTags where TagName='" + tagName + "'";
                _cmd.Connection = _con;
                _cmd.ExecuteNonQuery();
                _con.Close();

                return true;
            }
            catch (Exception er)
            {
                _con.Close();
                return false;
            }
        }




        //FILES---------------------------------------------------------------------------------
        public void loadFolder(string folder, DataGridView dgvFiles, ListView lstAllTags)
        {
            this._folder = folder;

            if (!File.Exists(_folder + "\\LitManDB.mdf"))
            {
                File.Copy(Application.StartupPath + "\\LitManDB.mdf", _folder + "\\LitManDB.mdf");
            }

            _con.ConnectionString = @"Data Source= (LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=" + _folder + "\\LitManDB.mdf;" +
                "Integrated Security=True";

            loadAllFiles(dgvFiles);
            loadAllTags(lstAllTags);
            loadTagsOfFiles(dgvFiles);
        }

        public void loadAllFiles(DataGridView dgvFiles)
        {
            DirectoryInfo dinfo = new DirectoryInfo(_folder);
            FileInfo[] Files = dinfo.GetFiles("*.pdf");

            dgvFiles.Rows.Clear();

            int count = 0;
            foreach (FileInfo file in Files)
            {
                dgvFiles.Rows.Add();
                dgvFiles["File", count].Value = file.Name;
                count++;
            }
        }

        public void loadFilteredFiles(DataGridView dgvFiles, string[] tags, string mode)
        {
            try
            {
                if (mode == "OR")
                {
                    string whereClouse = "";

                    for (int x = 0; x < tags.Length; x++)
                    {
                        whereClouse += "TagName='" + tags[x] + "' " + mode + " ";
                    }

                    whereClouse = whereClouse.Substring(0, whereClouse.Length - 3);

                    _con.Open();
                    _cmd.CommandText = "select distinct FileName from FilesTags where " + whereClouse;
                    _cmd.Connection = _con;
                    _reader = _cmd.ExecuteReader();

                    int count = 0;
                    while (_reader.Read())
                    {
                        dgvFiles.Rows.Add();
                        dgvFiles["File", count].Value = _reader[0].ToString();
                        count++;
                    }
                }


                if (mode == "AND")
                {
                    _con.Open();
                    _cmd.Connection = _con;

                    var listMain = new string[tags.Length][];

                    for (int x = 0; x < tags.Length; x++)
                    {
                        _cmd.CommandText = "select distinct FileName from FilesTags where TagName='" + tags[x] + "'";

                        using (_reader = _cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(_reader);

                            var listSub = new string[dt.Rows.Count];
                            int rowNum = 0;

                            _reader = _cmd.ExecuteReader();
                            while (_reader.Read())
                            {
                                listSub[rowNum] = _reader[0].ToString();
                                rowNum++;
                            }

                            listMain[x] = listSub;
                        }

                        _reader.Close();
                    }



                    //GET INTERSECT
                    if (tags.Length > 1)
                    {
                        var l2Lookup = new HashSet<string>(listMain[1]);
                        var interList = listMain[0].Where(l2Lookup.Contains);

                        for (int x = 1; x < tags.Length - 1; x++)
                        {
                            l2Lookup = new HashSet<string>(listMain[x + 1]);
                            var temp = listMain[x].Where(l2Lookup.Contains);
                            interList.Union(temp);
                        }

                        int count = 0;
                        foreach (var value in interList)
                        {
                            dgvFiles.Rows.Add();
                            dgvFiles["File", count].Value = value.ToString();
                            count++;
                        }
                    }
                    else
                    {
                        for (int x = 0; x < listMain[0].Length; x++)
                        {
                            dgvFiles.Rows.Add();
                            dgvFiles["File", x].Value = listMain[0][x].ToString();
                        }
                    }
                }

                _con.Close();
            }
            catch (Exception er)
            {
                _con.Close();
            }
        }

        public void loadTagsOfFiles(DataGridView dgvFiles)
        {
            string tagList = "";

            try
            {
                if (_con.State != ConnectionState.Open) { _con.Open(); }
                _cmd.Connection = _con;

                for (int x = 0; x < dgvFiles.Rows.Count; x++)
                {
                    _cmd.CommandText = "select distinct TagName, FileName from FilesTags";
                    _reader = _cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(_reader);

                    IEnumerable<DataRow> productsQuery = from dtColumn in dt.AsEnumerable() select dtColumn;
                    IEnumerable<DataRow> largeProducts = productsQuery.Where(p => p.Field<string>("FileName") == dgvFiles["File", x].Value.ToString());

                    foreach (DataRow product in largeProducts)
                    {
                        tagList += product.Field<string>("TagName") + " | ";
                    }

                    dgvFiles["Tags", x].Value = tagList;
                    tagList = "";
                }

                _con.Close();
            }
            catch (Exception er)
            {
                _con.Close();
            }
        }

        public string loadTagsOfFile(string fileName)
        {
            string tagList = "";

            try
            {
                _con.Open();
                _cmd.Connection = _con;

                _cmd.CommandText = "select distinct TagName from FilesTags where FileName='" + fileName + "'";
                _reader = _cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(_reader);

                foreach (DataRow row in dt.Rows)
                {
                    tagList += row[0].ToString() + " | ";
                }

                _con.Close();
            }
            catch (Exception er)
            {
                _con.Close();
            }

            return tagList;
        }



        public bool setTag(string tagName, string fileName)
        {
            try
            {
                _con.Open();
                _cmd.CommandText = "INSERT INTO FilesTags(FileName,TagName) VALUES ('" + fileName +
                    "','" + tagName + "')";
                _cmd.Connection = _con;
                _cmd.ExecuteNonQuery();
                _con.Close();

                return true;
            }
            catch (Exception er)
            {
                _con.Close();
                return false;
            }
        }

        public bool unsetTag(string tagName, string fileName)
        {
            try
            {
                _con.Open();
                _cmd.CommandText = "delete from FilesTags where TagName='" + tagName +
                    "' AND fileName='" + fileName + "'";
                _cmd.Connection = _con;
                _cmd.ExecuteNonQuery();
                _con.Close();

                return true;
            }
            catch (Exception er)
            {
                _con.Close();
                return false;
            }
        }

    }
}
