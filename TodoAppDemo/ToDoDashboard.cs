using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using TodoClassLibrary;
using System.Timers;

namespace TodoAppDemo
{
    public partial class ToDoDashboard : Form
    {
        public ToDoDashboard()
        {
            InitializeComponent();
            Left = 25;
            Top = 20;

            addTask1.Left = -addTask1.Width;
            directory = new AudioDirectories();

            todoProcessor = new TaskProcessor();
            player = new AudioAlarm();

            alarmTimer = new System.Timers.Timer(1000);
            alarmTimer.Elapsed += Timer_Elapsed;
        }

        #region Events

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            string ActiveTask = "";
            bool IsTaskDone = todoProcessor.CheckTask(out ActiveTask);
            if (IsTaskDone == true)
            {
                alarmTimer.Stop();
                alarm = new TaskAlarm($"{ActiveTask}");
                alarm.ShowDialog();
                
            }

            Todo_s.taskListBinding.ResetBindings(false);
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Todo_s.taskListBinding.ResetBindings(false);
            AddTask.soundListBinding.ResetBindings(false);
            
            Transition t = new Transition(new TransitionType_EaseInEaseOut(1000));

            if (btnMenu.SelectedIndex == 0)
            {
                t.add(addTask1, "Left", -addTask1.Width);
                todo_s1.Refresh();
                t.add(todo_s1, "Left", 0);
                t.run();
            }
            else if (btnMenu.SelectedIndex == 1)
            {
                t.add(todo_s1, "Left", todo_s1.Width);
                addTask1.Refresh();
                t.add(addTask1, "Left", 0);
                t.run();
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            DashboardTransitions();
        }

        private void listCounterTimer_Tick(object sender, EventArgs e)
        {
            TaskDisplay();
        }

        #endregion

        #region Class Fields

        public static System.Timers.Timer alarmTimer { get; set; }
        AudioDirectories directory;
        TaskProcessor todoProcessor;
        TaskAlarm alarm;
        AudioAlarm player;
        Screen display = Screen.PrimaryScreen;
        int taskCounter = 0;

        #endregion

        #region Private Functions

        private void DashboardTransitions()
        {
            if (this.Height == 430)
            {
                listCounterTimer.Enabled = true;

                Transition.run(this, "Height", 173, new TransitionType_EaseInEaseOut(1000));
                btnExpand.Text = "^";
                lblListCounter.Visible = true;
                Transition.run(lblListCounter, "Text", $"There are {TaskProcessor.TaskList.Count} total tasks on the list.", new TransitionType_EaseInEaseOut(1000));
                
                Transition.run(this, "Top", display.Bounds.Height - 173, new TransitionType_EaseInEaseOut(1000));
                btnMenu.Items = $"Todo's({TaskProcessor.TaskList.Count}), Add Task";
            }
            else
            {
                listCounterTimer.Enabled = false;

                Transition.run(this, "Height", 430, new TransitionType_EaseInEaseOut(1000));
                btnExpand.Text = "v";
                Transition.run(lblListCounter, "Text", "", new TransitionType_EaseInEaseOut(1000));

                Transition.run(this, "Top", 0, new TransitionType_EaseInEaseOut(1000));
                btnMenu.Items = $"Todo's, Add Task";
            }
        }

        private void TaskDisplay()
        {
            try
            {
                var task = TaskProcessor.TaskList;
                Transition.run(lblListCounter, "Text", $"{task[taskCounter].Title} At {task[taskCounter].TimeReminder}", new TransitionType_Linear(1000));
                taskCounter++;
            }
            catch
            {
                Transition.run(lblListCounter, "Text", $"There are {TaskProcessor.TaskList.Count} total tasks on the list.", new TransitionType_Linear(1000));
                taskCounter = 0;
            }
        }

        #endregion
    }
}
