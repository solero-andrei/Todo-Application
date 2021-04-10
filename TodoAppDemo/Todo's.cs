using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoClassLibrary;
using System.Reflection;
using System.IO;

namespace TodoAppDemo
{
    public partial class Todo_s : UserControl
    {   
        public Todo_s()
        {
            InitializeComponent();
            taskListBinding = new BindingSource();

            taskListBinding.DataSource = TaskProcessor.TaskList;
            taskList.DataSource = taskListBinding;

            taskList.DisplayMember = "TaskDisplay";
            taskList.ValueMember = "TaskDisplay";
        }

        #region Events

        private void btnTaskDone_Click(object sender, EventArgs e)
        {
            TaskDone();
        }

        #endregion

        #region Class Fields

        public static BindingSource taskListBinding { get; set; }

        #endregion

        #region Private Functions

        /// <summary>
        /// All the task selected will be mark as done.
        /// </summary>
        private void TaskDone()
        {
            try
            {
                int selectedTask = taskList.SelectedIndex;
                TaskProcessor.TaskList[selectedTask].IsReminded = false;
                TaskProcessor.TaskList[selectedTask].IsDone = true;

                taskListBinding.ResetBindings(false);
            }
            catch
            {
                ErrorProvider e = new ErrorProvider(this);
                e.SetError(taskList, "Please select a task first to mark as done");

            }
        }

        #endregion

    }
}
