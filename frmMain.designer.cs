namespace LearningTechnique.WinClient
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEducationGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEducationSubGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRole = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSampleCode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSoftwareLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrainingPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUserAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.userPolicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarPlansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblPnlTopMenu = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblClock = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.mnTextTodo = new System.Windows.Forms.ToolStripTextBox();
            this.mnTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackgroundImage = global::LearningTechnique.WinClient.Properties.Resources.learn_anything_with_feynman;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.dataToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.mnTextTodo,
            this.mnTodo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 461);
            this.menuStrip1.MdiWindowListItem = this.toolStripMenuItem1;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Rondalo", 10F);
            this.toolStripMenuItem1.Image = global::LearningTechnique.WinClient.Properties.Resources.if_Education_30691981;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 50);
            this.toolStripMenuItem1.Text = "Learning Technique";
            this.toolStripMenuItem1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEducationGroup,
            this.menuEducationSubGroup,
            this.menuRole,
            this.menuSampleCode,
            this.menuSoftwareLanguage,
            this.menuSubject,
            this.menuTrainingPlan,
            this.menuUserAccount,
            this.userPolicyToolStripMenuItem,
            this.userTokenToolStripMenuItem,
            this.calendarPlansToolStripMenuItem});
            this.dataToolStripMenuItem.Image = global::LearningTechnique.WinClient.Properties.Resources.if_file_code_299099;
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Padding = new System.Windows.Forms.Padding(50, 0, 4, 0);
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.dataToolStripMenuItem.Text = "Tables";
            this.dataToolStripMenuItem.MouseHover += new System.EventHandler(this.dataToolStripMenuItem_MouseHover);
            // 
            // menuEducationGroup
            // 
            this.menuEducationGroup.Image = global::LearningTechnique.WinClient.Properties.Resources.if_Education_3069198;
            this.menuEducationGroup.Name = "menuEducationGroup";
            this.menuEducationGroup.Size = new System.Drawing.Size(233, 24);
            this.menuEducationGroup.Tag = "EducationGroups";
            this.menuEducationGroup.Text = "EducationGroup";
            this.menuEducationGroup.Click += new System.EventHandler(this.menuEducationGroup_Click);
            // 
            // menuEducationSubGroup
            // 
            this.menuEducationSubGroup.Image = global::LearningTechnique.WinClient.Properties.Resources.if_Education_3069198;
            this.menuEducationSubGroup.Name = "menuEducationSubGroup";
            this.menuEducationSubGroup.Size = new System.Drawing.Size(233, 24);
            this.menuEducationSubGroup.Tag = "EducationSubGroups";
            this.menuEducationSubGroup.Text = "EducationSubGroup";
            this.menuEducationSubGroup.Click += new System.EventHandler(this.menuEducationSubGroup_Click);
            // 
            // menuRole
            // 
            this.menuRole.Image = global::LearningTechnique.WinClient.Properties.Resources.if_sign_up_49622;
            this.menuRole.Name = "menuRole";
            this.menuRole.Size = new System.Drawing.Size(233, 24);
            this.menuRole.Tag = "Roles";
            this.menuRole.Text = "Role";
            this.menuRole.Click += new System.EventHandler(this.menuRole_Click);
            // 
            // menuSampleCode
            // 
            this.menuSampleCode.Image = global::LearningTechnique.WinClient.Properties.Resources.if_file_code_299099;
            this.menuSampleCode.Name = "menuSampleCode";
            this.menuSampleCode.Size = new System.Drawing.Size(233, 24);
            this.menuSampleCode.Tag = "SampleCodes";
            this.menuSampleCode.Text = "SampleCode";
            this.menuSampleCode.Click += new System.EventHandler(this.menuSampleCode_Click);
            // 
            // menuSoftwareLanguage
            // 
            this.menuSoftwareLanguage.Image = global::LearningTechnique.WinClient.Properties.Resources.if_file_code_299099;
            this.menuSoftwareLanguage.Name = "menuSoftwareLanguage";
            this.menuSoftwareLanguage.Size = new System.Drawing.Size(233, 24);
            this.menuSoftwareLanguage.Tag = "SoftwareLanguages";
            this.menuSoftwareLanguage.Text = "SoftwareLanguage";
            this.menuSoftwareLanguage.Click += new System.EventHandler(this.menuSoftwareLanguage_Click);
            // 
            // menuSubject
            // 
            this.menuSubject.Image = global::LearningTechnique.WinClient.Properties.Resources.if_Education_3069198;
            this.menuSubject.Name = "menuSubject";
            this.menuSubject.Size = new System.Drawing.Size(233, 24);
            this.menuSubject.Tag = "Subjects";
            this.menuSubject.Text = "Subject";
            this.menuSubject.Click += new System.EventHandler(this.menuSubject_Click);
            // 
            // menuTrainingPlan
            // 
            this.menuTrainingPlan.Image = global::LearningTechnique.WinClient.Properties.Resources.if_calendar_clock_299096;
            this.menuTrainingPlan.Name = "menuTrainingPlan";
            this.menuTrainingPlan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuTrainingPlan.Size = new System.Drawing.Size(233, 24);
            this.menuTrainingPlan.Tag = "TrainingPlannings";
            this.menuTrainingPlan.Text = "Training Planning";
            this.menuTrainingPlan.Click += new System.EventHandler(this.menuTrainingPlan_Click);
            // 
            // menuUserAccount
            // 
            this.menuUserAccount.Image = global::LearningTechnique.WinClient.Properties.Resources.if_User_Executive_1_1218730;
            this.menuUserAccount.Name = "menuUserAccount";
            this.menuUserAccount.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.menuUserAccount.Size = new System.Drawing.Size(233, 24);
            this.menuUserAccount.Tag = "UserAccounts";
            this.menuUserAccount.Text = "UserAccount";
            this.menuUserAccount.Click += new System.EventHandler(this.menuUserAccount_Click);
            // 
            // userPolicyToolStripMenuItem
            // 
            this.userPolicyToolStripMenuItem.Image = global::LearningTechnique.WinClient.Properties.Resources.PadLock;
            this.userPolicyToolStripMenuItem.Name = "userPolicyToolStripMenuItem";
            this.userPolicyToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.userPolicyToolStripMenuItem.Tag = "UserPolicies";
            this.userPolicyToolStripMenuItem.Text = "User Policy";
            this.userPolicyToolStripMenuItem.Click += new System.EventHandler(this.userPolicyToolStripMenuItem_Click);
            // 
            // userTokenToolStripMenuItem
            // 
            this.userTokenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.userTokenToolStripMenuItem.Image = global::LearningTechnique.WinClient.Properties.Resources.token;
            this.userTokenToolStripMenuItem.Name = "userTokenToolStripMenuItem";
            this.userTokenToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.userTokenToolStripMenuItem.Tag = "UserTokens";
            this.userTokenToolStripMenuItem.Text = "User Token";
            this.userTokenToolStripMenuItem.Click += new System.EventHandler(this.userTokenToolStripMenuItem_Click);
            // 
            // calendarPlansToolStripMenuItem
            // 
            this.calendarPlansToolStripMenuItem.Name = "calendarPlansToolStripMenuItem";
            this.calendarPlansToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.calendarPlansToolStripMenuItem.Tag = "CalendarPlans";
            this.calendarPlansToolStripMenuItem.Text = "CalendarPlans";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::LearningTechnique.WinClient.Properties.Resources.if_User_Executive_1_1218730;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // tblPnlTopMenu
            // 
            this.tblPnlTopMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.tblPnlTopMenu.ColumnCount = 1;
            this.tblPnlTopMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblPnlTopMenu.Location = new System.Drawing.Point(0, 0);
            this.tblPnlTopMenu.Name = "tblPnlTopMenu";
            this.tblPnlTopMenu.RowCount = 1;
            this.tblPnlTopMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlTopMenu.Size = new System.Drawing.Size(1007, 11);
            this.tblPnlTopMenu.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 11);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1007, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = global::LearningTechnique.WinClient.Properties.Resources._new;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::LearningTechnique.WinClient.Properties.Resources._default;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Subject Layout Open";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::LearningTechnique.WinClient.Properties.Resources.clogo;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Subject Add+";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = global::LearningTechnique.WinClient.Properties.Resources.todo;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "Todo List";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClock.Font = new System.Drawing.Font("Elephant", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(846, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(161, 33);
            this.lblClock.TabIndex = 9;
            this.lblClock.Text = "label1";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblClock.UseCompatibleTextRendering = true;
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainLayout.Location = new System.Drawing.Point(0, 39);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Size = new System.Drawing.Size(234, 237);
            this.mainLayout.TabIndex = 11;
            // 
            // mnTextTodo
            // 
            this.mnTextTodo.AutoSize = false;
            this.mnTextTodo.BackColor = System.Drawing.Color.Yellow;
            this.mnTextTodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mnTextTodo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mnTextTodo.Name = "mnTextTodo";
            this.mnTextTodo.Size = new System.Drawing.Size(400, 18);
            // 
            // mnTodo
            // 
            this.mnTodo.BackColor = System.Drawing.Color.Black;
            this.mnTodo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mnTodo.ForeColor = System.Drawing.Color.Yellow;
            this.mnTodo.Name = "mnTodo";
            this.mnTodo.Size = new System.Drawing.Size(79, 26);
            this.mnTodo.Text = "Add Todo";
            this.mnTodo.Click += new System.EventHandler(this.mnTodo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::LearningTechnique.WinClient.Properties.Resources.if_Education_3069198;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1007, 491);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tblPnlTopMenu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainLayout);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Tag = "LearningTechnique V1.0";
            this.Text = "LearningTechnique V1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuEducationGroup;
        private System.Windows.Forms.ToolStripMenuItem menuEducationSubGroup;
        private System.Windows.Forms.ToolStripMenuItem menuRole;
        private System.Windows.Forms.ToolStripMenuItem menuSampleCode;
        private System.Windows.Forms.ToolStripMenuItem menuSoftwareLanguage;
        private System.Windows.Forms.ToolStripMenuItem menuSubject;
        private System.Windows.Forms.ToolStripMenuItem menuTrainingPlan;
        private System.Windows.Forms.ToolStripMenuItem menuUserAccount;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userPolicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarPlansToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tblPnlTopMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblClock;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel mainLayout;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox mnTextTodo;
        private System.Windows.Forms.ToolStripMenuItem mnTodo;
    }
}

