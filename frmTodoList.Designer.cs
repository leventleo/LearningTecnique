namespace LearningTechnique.WinClient
{
    partial class frmTodoList
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
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnFinishedTask = new System.Windows.Forms.ToolStripMenuItem();
            this.flwLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.mnPendingTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectFilterTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFilterTasksToolStripMenuItem,
            this.toolStripSeparator1,
            this.mnFinishedTask,
            this.toolStripSeparator2,
            this.mnPendingTasks});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(181, 104);
            // 
            // mnFinishedTask
            // 
            this.mnFinishedTask.Name = "mnFinishedTask";
            this.mnFinishedTask.Size = new System.Drawing.Size(180, 22);
            this.mnFinishedTask.Tag = "Finished Tasks";
            this.mnFinishedTask.Text = "Finished Tasks";
            this.mnFinishedTask.Click += new System.EventHandler(this.mnFinishedTask_Click);
            // 
            // flwLayout
            // 
            this.flwLayout.Location = new System.Drawing.Point(3, 12);
            this.flwLayout.Name = "flwLayout";
            this.flwLayout.Size = new System.Drawing.Size(367, 318);
            this.flwLayout.TabIndex = 1;
            // 
            // mnPendingTasks
            // 
            this.mnPendingTasks.Name = "mnPendingTasks";
            this.mnPendingTasks.Size = new System.Drawing.Size(180, 22);
            this.mnPendingTasks.Tag = "Pending Tasks";
            this.mnPendingTasks.Text = "Pending Tasks";
            this.mnPendingTasks.Click += new System.EventHandler(this.mnPendingTasks_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // selectFilterTasksToolStripMenuItem
            // 
            this.selectFilterTasksToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.selectFilterTasksToolStripMenuItem.Image = global::LearningTechnique.WinClient.Properties.Resources.todo;
            this.selectFilterTasksToolStripMenuItem.Name = "selectFilterTasksToolStripMenuItem";
            this.selectFilterTasksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectFilterTasksToolStripMenuItem.Text = "Select Filter Tasks";
            // 
            // frmTodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(504, 766);
            this.ContextMenuStrip = this.ctxMenu;
            this.Controls.Add(this.flwLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(520, 800);
            this.MinimumSize = new System.Drawing.Size(520, 800);
            this.Name = "frmTodoList";
            this.Text = "TodoList";
            this.Load += new System.EventHandler(this.frmTodoList_Load);
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem mnFinishedTask;
        public System.Windows.Forms.FlowLayoutPanel flwLayout;
        private System.Windows.Forms.ToolStripMenuItem mnPendingTasks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem selectFilterTasksToolStripMenuItem;
    }
}