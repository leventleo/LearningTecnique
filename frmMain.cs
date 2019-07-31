using AutoMapper;
using LearningTechnique.Business.Helper;
using LearningTechnique.BusinessDTO.DTO;
using LearningTechnique.CrosCuttingConcerns.Validation;
using LearningTechnique.DataAccess.Concreate;
using LearningTechnique.DataAccess.Interfaces;
using LearningTechnique.DataAccess.NinjectBindings;
using LearningTechnique.Entity.Entities;
using LearningTechnique.WinClient.CustomComponent;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using Workaholic.RTFEditor;
using LeoCache = LearningTechnique.CrosCuttingConcerns.Caching;
using Mappers = LearningTechnique.CrosCuttingConcerns.AutoMapper.Mappers;

namespace LearningTechnique.WinClient
{
    public partial class frmMain : Form
    {
        public delegate void DbEvent(object sender, Action action = null);

        private IKernel kernel = new StandardKernel(new BindingsNinject());
        private IMapper mapper = Mappers.MapTo();
        private LeoCache.ICache cache;
        private frmTable frmTables;
        public event DbEvent dbChanged;


        public frmMain()
        {


            InitializeComponent();


        }

        private int eduID = 0;
        private void frmMain_Load(object sender, EventArgs e)
        {
            mainLayout.Width = this.ClientSize.Width;
            mainLayout.Height = this.ClientSize.Height - 40;
            Clock();

            frmLogin frmlogin = new frmLogin();
            frmlogin.ShowDialog();

            this.Text = this.Tag.ToString() + $"   [{Helper.User}  {Helper.Role}]";
            if (Helper.Role == "Administrator")
            { tblPnlTopMenu.BackColor = Color.LimeGreen; }

            LoadSubject();

        }

        private void LoadSubject()
        {
            mainLayout.Controls.Clear();
            ISoftwareLanguage languageRepository = kernel.Get<ISoftwareLanguage>();
            var software = languageRepository.GetAll().OrderBy(X => X.SoftwareLanguageName).ToList();
            IEducationGroup educationGroupRepository = kernel.Get<IEducationGroup>();

            software.ForEach(f =>
            {
                var educaions = educationGroupRepository.GetByQuery(x => x.SoftwareLanguageID == f.ID).Count();
                CreateMiniForm(f.SoftwareLanguageName, f.ID, GroupName.Education, educaions,f.Logo);
            });


        }

        private void CreateMiniForm(string text, int id, GroupName groupName, int count,string logo)
        {
            ResourceManager resManager = new ResourceManager("LearningTechnique.WinClient.Properties.Resources", Assembly.GetExecutingAssembly());
            var img = (Bitmap)resManager.GetObject(logo);
            resManager.ReleaseAllResources();

            miniForm mini = new miniForm();
            mini.Software = text;
            mini.label1.Click += Label1_Click;
            mini.label1.Tag = id;
            mini.GroupName = groupName;
            mini.Count = count;
            mini.Logo = img;
            mini.LogoPath = logo;
            mainLayout.Controls.Add(mini);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

            Label label = (sender as Label);
            var path = (label.Parent as miniForm).LogoPath;
            int id = (int)label.Tag;
            switch ((label.Parent as miniForm).GroupName)
            {
                case GroupName.Education:
                    Edu(id,path);
                    break;
                case GroupName.SubEducation:
                    subEdu(id,path);
                    break;
                case GroupName.Subject:
                    subject(eduID, id,path);
                    break;
                case GroupName.open:
                    SubjectOpen(id);
                    break;
                default:
                    break;
            }





        }
        string logo;
        private void SubjectOpen(int id)
        {
            mainLayout.Visible = false;
            ISubject educationGroupRepository = kernel.Get<ISubject>();
            var subEdu = educationGroupRepository.GetByQuery(x => x.ID == id).SingleOrDefault();
            uCtrlEducationFrm userFrm = new uCtrlEducationFrm();

            userFrm.grpEducations.Visible = false;
            (userFrm.grpSubject.Controls["txtDEsciption"] as TextBox).Text = subEdu.Description;
            (userFrm.grpSubject.Controls["txtLink"] as TextBox).Text = subEdu.SourceLink;
            (userFrm.grpSubject.Controls["rtfEditor"] as RTFEditor).DocumentRtf = subEdu.Subject_;
            frmAddItem frmAddItem = new frmAddItem();
            frmAddItem.Controls.Add(userFrm);
            frmAddItem.MdiParent = this;
            frmAddItem.Show();
            frmAddItem.WindowState = FormWindowState.Maximized;
        }

        private void subject(int edID, int subID,string path)
        {

            ISubject educationGroupRepository = kernel.Get<ISubject>();
            var subEdu = educationGroupRepository.GetByQuery(x => x.EducationID == edID && x.SubEducationID == subID).OrderBy(o => o.Description).ToList();
            if (subEdu.Count<1)
            {
                return;
            }

            mainLayout.Controls.Clear();

            subEdu.ForEach(ed =>
            {

                CreateMiniForm(ed.Description, ed.ID, GroupName.open, 0,path);

            });

        }

        private void subEdu(int id,string path)
        {
            eduID = id;
            ISubject subjectRepository = kernel.Get<ISubject>();
            IEducationSubGroup educationGroupRepository = kernel.Get<IEducationSubGroup>();
            var subEdu = educationGroupRepository.GetByQuery(x => x.EducationID == id).OrderBy(o => o.SubEducationName).ToList();
            if (subEdu.Count < 1)
            {
                return;
            }

            mainLayout.Controls.Clear();

            subEdu.ForEach(ed =>
            {
                var count = subjectRepository.GetByQuery(x => x.SubEducationID == ed.ID).Count();
                CreateMiniForm(ed.SubEducationName, ed.ID, GroupName.Subject, count,path);

            });
        }

        private void Edu(int id,string path)
        {
            IEducationSubGroup subGroupRepository = kernel.Get<IEducationSubGroup>();

            IEducationGroup educationGroupRepository = kernel.Get<IEducationGroup>();
            var educaions = educationGroupRepository.GetByQuery(x => x.SoftwareLanguageID == id).OrderBy(o => o.EducationName).ToList();
            if (educaions.Count<1)
            {
                return;
            }

            mainLayout.Controls.Clear();

            educaions.ForEach(ed =>
            {
                var subEdu = subGroupRepository.GetByQuery(x => x.EducationID == ed.ID).Count();
                CreateMiniForm(ed.EducationName, ed.ID, GroupName.SubEducation, subEdu,path);

            });
        }

        private void Clock()
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }





        #region Metods


        private void openTableForm(string frmName, object DataSource, Type userControl = null, Type Repos = null)
        {
            if (frmTables == null || frmTables.IsDisposed)
            {
                frmTables = new frmTable();

            }

            if (Application.OpenForms.OfType<frmTable>().Count() != 1)
            {
                frmTables.Repository = Repos;
                frmTables.UserControl = userControl;
                frmTables.Text = frmName;
                frmTables.TabName = frmName;
                frmTables.DataSource = DataSource;
                frmTables.IsMdiContainer = false;
                frmTables.MdiParent = this;
                frmTables.TopMost = true;
                frmTables.Show();
                mainLayout.Visible = false;



            }

        }
        private void Logout()
        {
            IValidate validate = new UserValidation(null, null);
            validate.ValidateUserPolicy(this, Helper.RoleID);
            var dialogResult = MessageBox.Show("Do you want to Logout !", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            tblPnlTopMenu.BackColor = Color.DodgerBlue;

            Helper.User = string.Empty;
            Helper.Role = string.Empty;
            var openForms = Application.OpenForms.OfType<Form>().Where(x => x.Name != "frmMain").ToList();
            if (openForms.Count > 0)
            {
                foreach (var form in openForms)
                {
                    form.Close();
                }
            }
            this.Text = this.Tag.ToString();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            if (Helper.Role == "Administrator")
            {
                tblPnlTopMenu.BackColor = Color.LimeGreen;
            }

            this.Text = this.Tag.ToString() + $"   [{Helper.User}  {Helper.Role}]";
        }
        #endregion

        #region Tables
        private void menuUserAccount_Click(object sender, EventArgs e)
        {
            string name = "UserAccount";
            var ResultDTO = Mappers.GetDTOs<List<UserAccountDTO>, UserAccount, UserAccountRepository>(name);

            openTableForm(name, ResultDTO, typeof(uCtrlUserAccounts), typeof(UserAccountRepository));
        }

        private void menuTrainingPlan_Click(object sender, EventArgs e)
        {
            string name = "TrainingPlanning";
            var ResultDTO = Mappers.GetDTOs<List<TrainingPlanningDTO>, TrainingPlanning, TrainingPlanningRepository>(name);

            openTableForm(name, ResultDTO, null, typeof(TrainingPlanningRepository));
        }

        private void menuSubject_Click(object sender, EventArgs e)
        {
            string name = "Subject";
            var ResultDTO = Mappers.GetDTOs<List<SubjectDTO>, Subject, SubjectRepository>(name);

            openTableForm(name, ResultDTO, typeof(uCtrlEducationFrm), typeof(SubjectRepository));
        }

        private void menuSoftwareLanguage_Click(object sender, EventArgs e)
        {
            string name = "SoftwareLanguage";
            var ResultDTO = Mappers.GetDTOs<List<SoftwareLanguageDTO>, SoftwareLanguage, SoftwareLanguageRepository>(name);

            openTableForm(name, ResultDTO, null, typeof(SoftwareLanguageRepository));
        }

        private void menuSampleCode_Click(object sender, EventArgs e)
        {
            string name = "SampleCode";
            var ResultDTO = Mappers.GetDTOs<List<SampleCodeDTO>, SampleCode, SampleCodeRepository>(name);

            openTableForm(name, ResultDTO, null, typeof(SampleCodeRepository));
        }

        private void menuRole_Click(object sender, EventArgs e)
        {
            string name = "Role";
            var ResultDTO = Mappers.GetDTOs<List<RoleDTO>, Role, RoleRepository>(name);

            openTableForm(name, ResultDTO, null, typeof(RoleRepository));
        }

        private void menuEducationSubGroup_Click(object sender, EventArgs e)
        {
            string name = "EducationSubGroup";
            var ResultDTO = Mappers.GetDTOs<List<EducationSubGroupDTO>, EducationSubGroup, EducationSubGroupRepository>(name);

            openTableForm(name, ResultDTO, null, typeof(EducationSubGroupRepository));
        }

        private void menuEducationGroup_Click(object sender, EventArgs e)
        {
            string name = "EducationGroup";
            var ResultDTO = Mappers.GetDTOs<List<EducationGroupDTO>, EducationGroup, EducationGroupRepository>(name);

            openTableForm(name, ResultDTO, null, typeof(EducationGroupRepository));
        }
        private void userTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = "UserToken";
            var ResultDTO = Mappers.GetDTOs<List<UserTokenDTO>, UserToken, UserTokenRepository>(name);

            openTableForm(name, ResultDTO, null, typeof(UserTokenRepository));
        }

        private void userPolicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = "UserPolicy";
            var ResultDTO = Mappers.GetDTOs<List<UserPolicyDTO>, UserPolicy, UserPolicyRepository>(name);

            openTableForm(name, ResultDTO, typeof(uCtrlUserPolicy), typeof(UserPolicyRepository));
        }

        #endregion


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) => Logout();

        private void dataToolStripMenuItem_MouseHover(object sender, EventArgs e) => this.BackColor = Color.Red;

        private void searchToolBar1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var item = e.ClickedItem;
        }



        private void newToolStripButton_Click_1(object sender, EventArgs e)
        {


            try
            {
                if (Helper.Role != "Administrator")
                {
                    return;
                }

                var frmActive = Application.OpenForms.OfType<frmMain>().Select(x => x.ActiveMdiChild).SingleOrDefault() as frmTable;

                if (frmActive != null)
                {

                    frmAddItem frmAddItemForTable = new frmAddItem();
                    frmAddItemForTable.IsMdiContainer = false;
                    frmAddItemForTable.MdiParent = this;
                    frmAddItemForTable.Text = frmActive.Text;
                    UserControl ctrlUserControl = (UserControl)Activator.CreateInstance(frmTables.UserControl);
                    frmAddItemForTable.Controls.Add(ctrlUserControl);
                    frmAddItemForTable.Width = ctrlUserControl.Width + 20;
                    frmAddItemForTable.Height = ctrlUserControl.Height + 30;
                    frmAddItemForTable.Show();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        private void mainLayout_SizeChanged(object sender, EventArgs e)
        {
            mainLayout.Size = this.ClientSize;
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            mainLayout.Width = this.ClientSize.Width;
            mainLayout.Height = this.ClientSize.Height - 40;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoadSubject();
            mainLayout.Visible = true;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            mainLayout.Visible = false;

            frmAddItem frmAddItemForTable = new frmAddItem();
            frmAddItemForTable.IsMdiContainer = false;
            frmAddItemForTable.MdiParent = this;
            frmAddItemForTable.Text = "Subject Add +";
            uCtrlEducationFrm ctrlUserControl = new uCtrlEducationFrm();
            frmAddItemForTable.Controls.Add(ctrlUserControl);
            frmAddItemForTable.Width = ctrlUserControl.Width + 20;
            frmAddItemForTable.Height = ctrlUserControl.Height + 30;
            frmAddItemForTable.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            mainLayout.Visible = false;
            frmTodoList frm = new frmTodoList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnTodo_Click(object sender, EventArgs e)
        {
            try
            {
                ITodo todoRepository = kernel.Get<ITodo>();
                var todo = new Todo
                {

                    Task = mnTextTodo.Text

                };
                todoRepository.Add(todo);
                todoRepository.Save();
               
                mnTextTodo.Text = "";

                frmTodoList frm = Application.OpenForms.OfType<frmTodoList>().SingleOrDefault();
                if (frm!=null)
                {
                    object dt = todo.CreatTime != null ? todo.CreatTime : null;
                    UserControlTodoList userControlTodoList = new UserControlTodoList();
                    userControlTodoList.CloseTodo = false;
                    userControlTodoList.ID = todo.ID;
                    userControlTodoList.cbxTodo.Text = todo.Task;
                    userControlTodoList.CreatDate = Convert.ToDateTime(dt);
                    userControlTodoList.FinishDate = DateTime.Now;
                    frm.flwLayout.Controls.Add(userControlTodoList);
                    frm.flwLayout.Controls.SetChildIndex(userControlTodoList, 0);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
