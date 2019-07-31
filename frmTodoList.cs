using LearningTechnique.DataAccess.Concreate;
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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningTechnique.WinClient
{
    public partial class frmTodoList : Form
    {
        public frmTodoList()
        {
            InitializeComponent();
        }

        IKernel kernel = new StandardKernel(new BindingsNinject());
        ITodo todoRepository;

        private void frmTodoList_Load(object sender, EventArgs e)
        {
            flwLayout.Size = this.ClientSize;

            LoadTaskData(x=>x.ID>-1);
            
        }

        private void LoadTaskData( Expression<Func<Todo,bool>> filter )
        {
            flwLayout.Controls.Clear();

            var result = LoadTodo();
            var finishCount = result.Where(x => x.TombStone != null).Count();
            var pendingCount = result.Where(x => x.TombStone == null).Count();

            mnFinishedTask.Text = mnFinishedTask.Tag.ToString();
            mnPendingTasks.Text = mnPendingTasks.Tag.ToString();
            mnFinishedTask.Text = string.Format($"{ mnFinishedTask.Text} ({finishCount})");
            mnPendingTasks.Text = string.Format($"{mnPendingTasks.Text} ({pendingCount})");
            result = result.AsQueryable().Where(filter).ToList();
            result.ForEach(t => {

                UserControlTodoList userControlTodoList = new UserControlTodoList();
                if (t.TombStone.HasValue)
                {
                    userControlTodoList.CloseTodo = true;
                }
                else
                {
                    userControlTodoList.CloseTodo = false;
                }
                var dt = t.TombStone.HasValue ? t.TombStone : DateTime.Now;
                object ct = t.CreatTime != null ? t.CreatTime : null;
                userControlTodoList.CreatDate = Convert.ToDateTime(ct);
                userControlTodoList.FinishDate = dt;
                userControlTodoList.ID = t.ID;
                userControlTodoList.cbxTodo.Text = t.Task;
                flwLayout.Controls.Add(userControlTodoList);


            });
        }

        private List<Todo> LoadTodo()
        {
            
            todoRepository = kernel.Get<ITodo>();
            return todoRepository.GetAll().ToList();
        }

        private void mnFinishedTask_Click(object sender, EventArgs e)
        {
            checkControl(sender);
        }

        private void mnPendingTasks_Click(object sender, EventArgs e)
        {
            checkControl(sender);
        }

        private void checkControl(object sender)
        {
            var mnitem = (sender as ToolStripMenuItem);
            if (mnitem.CheckState == CheckState.Checked)
            {
                ///Seçili durumdan çıkar
                mnitem.Checked = false;

                if (mnitem.Name == "mnFinishedTask")
                {
                    LoadTaskData(x => x.TombStone == null);



                }
                else
                {
                    LoadTaskData(x => x.TombStone != null);

                }

            }
            else
            {/// Seçili duruma getir

                mnitem.Checked = true;

                if (mnitem.Name == "mnFinishedTask" )
                {
                    LoadTaskData(x => x.TombStone != null);



                }
                else
                {
                    LoadTaskData(x => x.TombStone == null);

                }
            }
        }

    }
}
