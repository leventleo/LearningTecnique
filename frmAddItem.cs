using LearningTechnique.DataAccess.NinjectBindings;
using LearningTechnique.Entity.Entities;
using Ninject;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using System.Linq;

namespace LearningTechnique.WinClient
{
    public partial class frmAddItem: Form
    
    {

        public  Type repositoryType { get; set; }
        
        public frmAddItem()
        {
            InitializeComponent();
            this.TopMost = true;
           
        }

        private void FrmAddItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            GC.SuppressFinalize(this);
        }



        private void frmAddItem_Load(object sender, EventArgs e)
        {
            
            this.FormClosed += FrmAddItem_FormClosed;
        }

        private void frmAddItem_SizeChanged(object sender, EventArgs e)
        {
            var userControl = this.Controls.OfType<UserControl>().SingleOrDefault();
            if(userControl!=null)
            {
                userControl.Size = this.ClientSize;

            }

        }
    }
}
