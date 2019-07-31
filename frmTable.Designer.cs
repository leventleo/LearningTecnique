namespace LearningTechnique.WinClient
{
    partial class frmTable
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
            this.ctxMenuTables = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.desingModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCtrlTable = new System.Windows.Forms.TabControl();
            this.tbpTable = new System.Windows.Forms.TabPage();
            this.dtgUserAccounts = new ADGV.AdvancedDataGridView();
            this.ctxMenuTables.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabCtrlTable.SuspendLayout();
            this.tbpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUserAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // ctxMenuTables
            // 
            this.ctxMenuTables.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ctxMenuTables.BackgroundImage = global::LearningTechnique.WinClient.Properties.Resources.search_button_icon_png_24;
            this.ctxMenuTables.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ctxMenuTables.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRecordToolStripMenuItem,
            this.updateRecordToolStripMenuItem,
            this.addRecordToolStripMenuItem,
            this.openRecordToolStripMenuItem});
            this.ctxMenuTables.Name = "ctxMenuTables";
            this.ctxMenuTables.Size = new System.Drawing.Size(181, 122);
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteRecordToolStripMenuItem.Image = global::LearningTechnique.WinClient.Properties.Resources.delete;
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.ShowShortcutKeys = false;
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.deleteRecordToolStripMenuItem.Text = "Delete Record";
            this.deleteRecordToolStripMenuItem.Click += new System.EventHandler(this.deleteRecordToolStripMenuItem_Click);
            // 
            // updateRecordToolStripMenuItem
            // 
            this.updateRecordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.updateRecordToolStripMenuItem.Image = global::LearningTechnique.WinClient.Properties.Resources.update;
            this.updateRecordToolStripMenuItem.Name = "updateRecordToolStripMenuItem";
            this.updateRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.updateRecordToolStripMenuItem.Text = "Update Record";
            // 
            // addRecordToolStripMenuItem
            // 
            this.addRecordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addRecordToolStripMenuItem.Image = global::LearningTechnique.WinClient.Properties.Resources.add;
            this.addRecordToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.addRecordToolStripMenuItem.Name = "addRecordToolStripMenuItem";
            this.addRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.addRecordToolStripMenuItem.Text = "Add Record";
            // 
            // openRecordToolStripMenuItem
            // 
            this.openRecordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.openRecordToolStripMenuItem.Name = "openRecordToolStripMenuItem";
            this.openRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.openRecordToolStripMenuItem.Text = "Open Record";
            this.openRecordToolStripMenuItem.Click += new System.EventHandler(this.openRecordToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desingModeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 26);
            // 
            // desingModeToolStripMenuItem
            // 
            this.desingModeToolStripMenuItem.Name = "desingModeToolStripMenuItem";
            this.desingModeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.desingModeToolStripMenuItem.Text = "Table Setting";
            // 
            // tabCtrlTable
            // 
            this.tabCtrlTable.ContextMenuStrip = this.contextMenuStrip1;
            this.tabCtrlTable.Controls.Add(this.tbpTable);
            this.tabCtrlTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlTable.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlTable.Name = "tabCtrlTable";
            this.tabCtrlTable.SelectedIndex = 0;
            this.tabCtrlTable.Size = new System.Drawing.Size(976, 484);
            this.tabCtrlTable.TabIndex = 1;
            // 
            // tbpTable
            // 
            this.tbpTable.Controls.Add(this.dtgUserAccounts);
            this.tbpTable.Location = new System.Drawing.Point(4, 22);
            this.tbpTable.Name = "tbpTable";
            this.tbpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTable.Size = new System.Drawing.Size(968, 458);
            this.tbpTable.TabIndex = 0;
            this.tbpTable.Text = "tabPage1";
            this.tbpTable.UseVisualStyleBackColor = true;
            // 
            // dtgUserAccounts
            // 
            this.dtgUserAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgUserAccounts.AutoGenerateContextFilters = true;
            this.dtgUserAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUserAccounts.ContextMenuStrip = this.ctxMenuTables;
            this.dtgUserAccounts.DateWithTime = false;
            this.dtgUserAccounts.Location = new System.Drawing.Point(8, 15);
            this.dtgUserAccounts.Name = "dtgUserAccounts";
            this.dtgUserAccounts.Size = new System.Drawing.Size(952, 437);
            this.dtgUserAccounts.TabIndex = 4;
            this.dtgUserAccounts.TimeFilter = false;
            this.dtgUserAccounts.SortStringChanged += new System.EventHandler(this.dtgUserAccounts_SortStringChanged);
            this.dtgUserAccounts.FilterStringChanged += new System.EventHandler(this.dtgUserAccounts_FilterStringChanged);
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 484);
            this.Controls.Add(this.tabCtrlTable);
            this.Name = "frmTable";
            this.Text = "frmUserAccount";
            this.Load += new System.EventHandler(this.frmUserAccount_Load);
            this.SizeChanged += new System.EventHandler(this.frmTable_SizeChanged);
            this.ctxMenuTables.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabCtrlTable.ResumeLayout(false);
            this.tbpTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUserAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem desingModeToolStripMenuItem;
        private System.Windows.Forms.TabPage tbpTable;
        public System.Windows.Forms.TabControl tabCtrlTable;
        private System.Windows.Forms.ContextMenuStrip ctxMenuTables;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private ADGV.AdvancedDataGridView dtgUserAccounts;
        private System.Windows.Forms.ToolStripMenuItem updateRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRecordToolStripMenuItem;
    }
}