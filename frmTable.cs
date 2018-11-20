using LearningTechnique.DataAccess.NinjectBindings;
using Ninject;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using LearningTechnique.Core.Abstract;
using System.IO;
using System.Data;
using LearningTechnique.CrosCuttingConcerns.Caching;
using System.Runtime.Caching;
using AutoMapper;
using LearningTechnique.CrosCuttingConcerns.AutoMapper;
using LearningTechnique.Business.ClientMetods;
using LearningTechnique.Business;

namespace LearningTechnique.WinClient
{
    public partial class frmTable : Form, IFrmTable
    {
        public frmTable()
        {
            InitializeComponent();
           
        }
       
        IKernel kernel = new StandardKernel(new BindingsNinject());
        private string _tabName;
        public object DataSource { get; set; }
        public Type UserControl { get; set; }
        public Type Repository { get; set; }
        public BindingSource bindingContext{ get; set; }= new BindingSource();


        public string TabName
        {
            get { return _tabName; }
            set
            {
                _tabName = value;
                tbpTable.Text = _tabName;

            }
        }

       public void UpdateDataSoruce(object source)
        {
             
            ICache cache = kernel.Get<ICache>();
            cache.Clear();
          //  frmTable frm = (frmTable)this.MemberwiseClone();
            bindingContext.DataSource= source;
          //  frm.Focus();
           
        }

       

        private void frmUserAccount_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            bindingContext.DataSource = DataSource;
            dtgUserAccounts.DataSource = bindingContext;
            dtgUserAccounts.Height = this.ClientSize.Height - 100;
            bindingContext.Sort = "ID";
           



        }






        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var _repository = Activator.CreateInstance(Repository);
            MethodInfo deleteMethod = _repository.GetType().GetMethod("Delete");
            MethodInfo saveMethod = _repository.GetType().GetMethod("Save");
           

            var selectRows = dtgUserAccounts.SelectedRows;
            if (selectRows != null)
            {
                for (int i = 0; i < selectRows.Count; i++)
                {
                    int id = Convert.ToInt32(selectRows[i].Cells["ID"].Value.ToString());
                    bindingContext.RemoveAt(selectRows[i].Index);
                    object entity = deleteMethod.Invoke(_repository, new object[] { id });
                   
                }
                 
                saveMethod.Invoke(_repository, null);
                ICache cache = kernel.Get<ICache>();
                cache.Clear();
                ClientHelper.UpdateDtg();
                dtgUserAccounts.Update();
                
                 
            }

            

        }

        private void frmTable_SizeChanged(object sender, EventArgs e)
        {
            dtgUserAccounts.Height = this.ClientSize.Height - 100;
        }

        private void dtgUserAccounts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dtg = (sender as DataGridView);

            foreach (DataGridViewRow item in dtg.Rows)
            {
                if (Convert.ToBoolean(item.Cells["IsActive"].Value) == false
                                   || item.Cells["TombStone"].Value != null)
                {
                    item.Cells["IsActive"].Style.BackColor = Color.Red;
                    item.Cells["TombStone"].Style.BackColor = Color.Red;

                }
                else
                {
                    item.Cells["IsActive"].Style.BackColor = Color.Green;
                    item.Cells["TombStone"].Style.BackColor = Color.Green;
                }

            }

        }

        private void imgBtnSearch_Click(object sender, EventArgs e)
        {
             
            

        }

        private void dtgUserAccounts_SortStringChanged(object sender, EventArgs e)
        {
           bindingContext.Sort = dtgUserAccounts.SortString;
             
        }

        private void dtgUserAccounts_FilterStringChanged(object sender, EventArgs e)
        { 
            bindingContext.Filter = dtgUserAccounts.FilterString;

        }

        private void openRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl ctrlUserControl = (UserControl)Activator.CreateInstance(UserControl);
            var _propInfo = ctrlUserControl.GetType().GetProperty("MyProperty");
             var fields= (List<object>)_propInfo.GetValue(ctrlUserControl);
           
            if (dtgUserAccounts.SelectedRows.Count>0)
            {
                var selectRows = dtgUserAccounts.SelectedRows[0];
                for (int i = 0; i < selectRows.Cells.Count-6; i++)
                {
                     fields.Add(selectRows.Cells[i].Value.ToString());

                }

                _propInfo.SetValue(ctrlUserControl, fields);
                frmAddItem frmAddItem = new frmAddItem();
                frmAddItem.Controls.Add(ctrlUserControl);
                frmAddItem.WindowState = FormWindowState.Maximized;
                frmAddItem.Show();
            }

           
        }

       
    }
}