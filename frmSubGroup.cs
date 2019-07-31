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
    public partial class frmSubGroup : Form
    {
        public frmSubGroup()
        {
            InitializeComponent();
            subEducationrepository = kernel.Get<IEducationSubGroup>();
        }
                
        public string SoftwareText { get; set; }
        public int EducationID { get; set; }
        public string EducationText { get; set; }
        IKernel kernel = new StandardKernel(new BindingsNinject());
        IEducationSubGroup subEducationrepository;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSubEducation.Text))
            {
                var subEducaiton = new EducationSubGroup
                {

                     EducationID=EducationID,
                      SubEducationName=txtSubEducation.Text

                };


                subEducationrepository.Add(subEducaiton);
                subEducationrepository.Save();
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
                MessageBox.Show("Plase Fill in the SubGroup Education field !");
            }
        }

        private void frmSubGroup_Load(object sender, EventArgs e)
        {
            txtSoftware.Text = SoftwareText;
            txtEducation.Text = EducationText;
        }
    }
}
