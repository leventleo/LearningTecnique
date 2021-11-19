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
    public partial class frmSoftware : Form
    {

        IKernel kernel;
        ISoftwareLanguage softwareLanguageRepository;
        public Form frmAddİtem { get; set; }

        public frmSoftware()
        {
            InitializeComponent();
            kernel = new StandardKernel(new BindingsNinject());
            softwareLanguageRepository = kernel.Get<ISoftwareLanguage>();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtSoftware.Text))
            {
                var software = new SoftwareLanguage
                {
                    SoftwareLanguageName = txtSoftware.Text
                };

                softwareLanguageRepository.Add(software);
                softwareLanguageRepository.Save();
              // MessageBox.Show("Added Software Language!");
                Form _frmAddItem=(Form) Application.OpenForms.OfType<frmAddItem>().SingleOrDefault();
                if (_frmAddItem!=null)
                {
                    uCtrlEducationFrm frmControl = (uCtrlEducationFrm)_frmAddItem.Controls[0];

                    frmControl.SoftwareHasCange = true;
                    this.Close();
                    this.Dispose();
                }
                else
                    MessageBox.Show("frmAddItem Form is null");



            }
            else
            {
                MessageBox.Show("Please fill in Software Language field !");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSoftware_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
