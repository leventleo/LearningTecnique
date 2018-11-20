
using LearningTechnique.Business.Helper;
using LearningTechnique.CrosCuttingConcerns.Validation;
using LearningTechnique.DataAccess.NinjectBindings;
using Ninject;
using System;
using System.Windows.Forms;

namespace LearningTechnique.WinClient
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
           
        }
        public bool BtnOk { get; set; } = false;
        public bool BtnCancel { get; set; } = false;
        public string UserName { get; set; }
        public string Password { get; set; }
        private IValidate validate;
      //  IKernel kernel = new StandardKernel(new BindingsNinject());

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Text = Properties.Settings.Default.UserName;
            txtPassword.Text = Properties.Settings.Default.Password;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            try
            {
                BtnOk = true;
                UserName = txtUser.Text;
                Password = txtPassword.Text;
                validate = new UserValidation(UserName, Password);
                if (validate.Validate())
                {
                    this.Close();
                   var frmMain= Application.OpenForms["frmMain"];
                    validate.ValidateUserPolicy(frmMain, Helper.RoleID);

                

                }

                else
                    MessageBox.Show("Your username or password is incorrect. !", "Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message+"\n"+ex.InnerException);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BtnCancel = true;
            Application.Exit();

        }    
    }
}
