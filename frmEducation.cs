using LearningTechnique.DataAccess.Interfaces;
using LearningTechnique.DataAccess.NinjectBindings;
using LearningTechnique.Entity.Entities;
using LearningTechnique.WinClient.CustomComponent;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningTechnique.WinClient
{
    public partial class frmEducation : Form
    {
        public frmEducation()
        {
            InitializeComponent();
            educationrepository = kernel.Get<IEducationGroup>();
        }

        public int SoftwareLanguageID { get; set; }
        public string SoftwareText { get; set; }
        IKernel kernel = new StandardKernel( new BindingsNinject());
        IEducationGroup educationrepository;
        private void frmEducation_Load(object sender, EventArgs e)
        {

            txtSoftware.Text = SoftwareText;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEducation.Text))
            {

                var educationGroup = new EducationGroup
                {
                    EducationName = txtEducation.Text,
                    SoftwareLanguageID = SoftwareLanguageID,

                };

                educationrepository.Add(educationGroup);
                educationrepository.Save();

                Form _frmAddItem = (Form)Application.OpenForms.OfType<frmAddItem>().SingleOrDefault();
                if (_frmAddItem != null)
                {
                    uCtrlEducationFrm frmControl = (uCtrlEducationFrm)_frmAddItem.Controls[0];

                    frmControl.EducationHasCange = true;
                    this.Close();
                    this.Dispose();
                }
                else
                    MessageBox.Show("frmAddItem Form is null");

            }
            else
            {
                MessageBox.Show("Please Fill in Education Group field !");
            }
        }
    }
}
