namespace FCS_Lit_Manager
{
    partial class FormSidebar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdoAnd = new System.Windows.Forms.RadioButton();
            this.rdoOr = new System.Windows.Forms.RadioButton();
            this.lstAllTags = new System.Windows.Forms.ListView();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUnsetTag = new System.Windows.Forms.Button();
            this.btnSetTag = new System.Windows.Forms.Button();
            this.btnRemoveTag = new System.Windows.Forms.Button();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.txtAddTag = new System.Windows.Forms.TextBox();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.Open = new System.Windows.Forms.DataGridViewButtonColumn();
            this.File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTipFolder = new System.Windows.Forms.ToolTip(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer2.IsSplitterFixed = true;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer2.Name = "SplitContainer2";
            this.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer2.Panel1
            // 
            this.SplitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SplitContainer2.Panel1.Controls.Add(this.tabControl1);
            this.SplitContainer2.Panel1.Controls.Add(this.txtFolder);
            this.SplitContainer2.Panel1.Controls.Add(this.btnBrowse);
            this.SplitContainer2.Panel1.Controls.Add(this.btnRefresh);
            this.SplitContainer2.Panel1.Controls.Add(this.btnUnsetTag);
            this.SplitContainer2.Panel1.Controls.Add(this.btnSetTag);
            this.SplitContainer2.Panel1.Controls.Add(this.btnRemoveTag);
            this.SplitContainer2.Panel1.Controls.Add(this.btnAddTag);
            this.SplitContainer2.Panel1.Controls.Add(this.txtAddTag);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.dgvFiles);
            this.SplitContainer2.Size = new System.Drawing.Size(264, 608);
            this.SplitContainer2.SplitterDistance = 280;
            this.SplitContainer2.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(222, 199);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.rdoAnd);
            this.tabPage1.Controls.Add(this.rdoOr);
            this.tabPage1.Controls.Add(this.lstAllTags);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(214, 173);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(111, 21);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // rdoAnd
            // 
            this.rdoAnd.AutoSize = true;
            this.rdoAnd.Checked = true;
            this.rdoAnd.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAnd.Location = new System.Drawing.Point(118, 6);
            this.rdoAnd.Name = "rdoAnd";
            this.rdoAnd.Size = new System.Drawing.Size(45, 17);
            this.rdoAnd.TabIndex = 8;
            this.rdoAnd.TabStop = true;
            this.rdoAnd.Text = "AND";
            this.rdoAnd.UseVisualStyleBackColor = true;
            this.rdoAnd.CheckedChanged += new System.EventHandler(this.rdoAndOr_CheckedChanged);
            // 
            // rdoOr
            // 
            this.rdoOr.AutoSize = true;
            this.rdoOr.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOr.Location = new System.Drawing.Point(170, 6);
            this.rdoOr.Name = "rdoOr";
            this.rdoOr.Size = new System.Drawing.Size(38, 17);
            this.rdoOr.TabIndex = 9;
            this.rdoOr.Text = "OR";
            this.rdoOr.UseVisualStyleBackColor = true;
            this.rdoOr.CheckedChanged += new System.EventHandler(this.rdoAndOr_CheckedChanged);
            // 
            // lstAllTags
            // 
            this.lstAllTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAllTags.CheckBoxes = true;
            this.lstAllTags.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAllTags.HideSelection = false;
            this.lstAllTags.LabelEdit = true;
            this.lstAllTags.LabelWrap = false;
            this.lstAllTags.Location = new System.Drawing.Point(1, 28);
            this.lstAllTags.MultiSelect = false;
            this.lstAllTags.Name = "lstAllTags";
            this.lstAllTags.Size = new System.Drawing.Size(213, 145);
            this.lstAllTags.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstAllTags.TabIndex = 0;
            this.lstAllTags.UseCompatibleStateImageBehavior = false;
            this.lstAllTags.View = System.Windows.Forms.View.SmallIcon;
            this.lstAllTags.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lstAllTags_AfterLabelEdit);
            this.lstAllTags.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lstAllTags_BeforeLabelEdit);
            this.lstAllTags.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstAllTags_ItemChecked);
            // 
            // txtFolder
            // 
            this.txtFolder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolder.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolder.Location = new System.Drawing.Point(9, 5);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(104, 21);
            this.txtFolder.TabIndex = 13;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(113, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(55, 22);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(167, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(55, 22);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUnsetTag
            // 
            this.btnUnsetTag.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnsetTag.Location = new System.Drawing.Point(116, 253);
            this.btnUnsetTag.Name = "btnUnsetTag";
            this.btnUnsetTag.Size = new System.Drawing.Size(106, 23);
            this.btnUnsetTag.TabIndex = 7;
            this.btnUnsetTag.Text = "Un-set Tag";
            this.btnUnsetTag.UseVisualStyleBackColor = true;
            this.btnUnsetTag.Click += new System.EventHandler(this.btnUnsetTag_Click);
            // 
            // btnSetTag
            // 
            this.btnSetTag.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTag.Location = new System.Drawing.Point(9, 253);
            this.btnSetTag.Name = "btnSetTag";
            this.btnSetTag.Size = new System.Drawing.Size(106, 23);
            this.btnSetTag.TabIndex = 6;
            this.btnSetTag.Text = "Set Tag";
            this.btnSetTag.UseVisualStyleBackColor = true;
            this.btnSetTag.Click += new System.EventHandler(this.btnSetTag_Click);
            // 
            // btnRemoveTag
            // 
            this.btnRemoveTag.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveTag.Location = new System.Drawing.Point(167, 26);
            this.btnRemoveTag.Name = "btnRemoveTag";
            this.btnRemoveTag.Size = new System.Drawing.Size(55, 22);
            this.btnRemoveTag.TabIndex = 4;
            this.btnRemoveTag.Text = "Remove Tag";
            this.btnRemoveTag.UseVisualStyleBackColor = true;
            this.btnRemoveTag.Click += new System.EventHandler(this.btnRemoveTag_Click);
            // 
            // btnAddTag
            // 
            this.btnAddTag.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTag.Location = new System.Drawing.Point(113, 26);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(55, 22);
            this.btnAddTag.TabIndex = 3;
            this.btnAddTag.Text = "Add Tag";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // txtAddTag
            // 
            this.txtAddTag.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAddTag.Location = new System.Drawing.Point(9, 27);
            this.txtAddTag.Name = "txtAddTag";
            this.txtAddTag.Size = new System.Drawing.Size(104, 21);
            this.txtAddTag.TabIndex = 2;
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.AllowUserToResizeRows = false;
            this.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Open,
            this.File,
            this.Tags});
            this.dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFiles.Location = new System.Drawing.Point(0, 0);
            this.dgvFiles.MultiSelect = false;
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFiles.RowHeadersVisible = false;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(264, 324);
            this.dgvFiles.TabIndex = 1;
            this.dgvFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellClick);
            // 
            // Open
            // 
            this.Open.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Open.HeaderText = "O";
            this.Open.MinimumWidth = 20;
            this.Open.Name = "Open";
            this.Open.ReadOnly = true;
            this.Open.Width = 20;
            // 
            // File
            // 
            this.File.HeaderText = "File";
            this.File.Name = "File";
            this.File.ReadOnly = true;
            // 
            // Tags
            // 
            this.Tags.HeaderText = "Tags";
            this.Tags.Name = "Tags";
            this.Tags.ReadOnly = true;
            // 
            // FormSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 608);
            this.Controls.Add(this.SplitContainer2);
            this.Name = "FormSidebar";
            this.Text = "FormSidebar";
            this.Load += new System.EventHandler(this.FormSidebar_Load);
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel1.PerformLayout();
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.SplitContainer SplitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdoAnd;
        private System.Windows.Forms.RadioButton rdoOr;
        internal System.Windows.Forms.ListView lstAllTags;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUnsetTag;
        private System.Windows.Forms.Button btnSetTag;
        private System.Windows.Forms.Button btnRemoveTag;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.TextBox txtAddTag;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewButtonColumn Open;
        private System.Windows.Forms.DataGridViewTextBoxColumn File;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tags;
        private System.Windows.Forms.ToolTip toolTipFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}