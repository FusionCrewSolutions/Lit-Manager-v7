namespace FCS_Lit_Manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspStsLbl = new System.Windows.Forms.ToolStripLabel();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabFolders = new System.Windows.Forms.TabControl();
            this.pdfViewer = new AxAcroPDFLib.AxAcroPDF();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTipFolder = new System.Windows.Forms.ToolTip(this.components);
            this.cmsFolder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).BeginInit();
            this.cmsFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspStsLbl});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 507);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(792, 25);
            this.ToolStrip1.TabIndex = 7;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // tspStsLbl
            // 
            this.tspStsLbl.Name = "tspStsLbl";
            this.tspStsLbl.Size = new System.Drawing.Size(0, 22);
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.tabFolders);
            this.SplitContainer1.Panel1MinSize = 230;
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.pdfViewer);
            this.SplitContainer1.Size = new System.Drawing.Size(792, 507);
            this.SplitContainer1.SplitterDistance = 230;
            this.SplitContainer1.TabIndex = 3;
            // 
            // tabFolders
            // 
            this.tabFolders.ContextMenuStrip = this.cmsFolder;
            this.tabFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFolders.Location = new System.Drawing.Point(0, 0);
            this.tabFolders.Name = "tabFolders";
            this.tabFolders.SelectedIndex = 0;
            this.tabFolders.ShowToolTips = true;
            this.tabFolders.Size = new System.Drawing.Size(230, 507);
            this.tabFolders.TabIndex = 0;
            this.tabFolders.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabFolders_MouseDown);
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Enabled = true;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfViewer.OcxState")));
            this.pdfViewer.Size = new System.Drawing.Size(558, 507);
            this.pdfViewer.TabIndex = 0;
            // 
            // cmsFolder
            // 
            this.cmsFolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFolderToolStripMenuItem});
            this.cmsFolder.Name = "cmsFolder";
            this.cmsFolder.Size = new System.Drawing.Size(131, 26);
            // 
            // addFolderToolStripMenuItem
            // 
            this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addFolderToolStripMenuItem.Text = "Add folder";
            this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 532);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.ToolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCS Lit Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).EndInit();
            this.cmsFolder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        private AxAcroPDFLib.AxAcroPDF pdfViewer;
        private System.Windows.Forms.ToolStripLabel tspStsLbl;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTipFolder;
        private System.Windows.Forms.TabControl tabFolders;
        private System.Windows.Forms.ContextMenuStrip cmsFolder;
        private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
    }
}

