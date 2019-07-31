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
    public partial class frmNotificationcs : Form
    {
        public frmNotificationcs()
        {
            InitializeComponent();
        }

        private void frmNotificationcs_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 20;
            if (Opacity<10)
            {
                timer1.Stop();
                this.Close();
                this.Dispose();
            }
        }
    }
}
