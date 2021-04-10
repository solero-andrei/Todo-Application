using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoClassLibrary;
using Transitions;

namespace TodoAppDemo
{
    public partial class TaskAlarm : Form
    {
        public TaskAlarm(string TaskTitle)
        {
            InitializeComponent();
            display = Screen.PrimaryScreen;           

            int x = 0 - this.Width;
            int y = display.Bounds.Height - (this.Height + 50);
            Location = new Point(x, y);

            lblTaskTitle.Text = TaskTitle;

            FormTransition();
        }

        #region Class Fields

        Screen display;
        AudioAlarm player = new AudioAlarm();

        #endregion

        #region Private Functions

        private void FormTransition()
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(300));
            t.add(this, "Left", 20);
            t.run();

            LabelTransition();
        }

        private void LabelTransition()
        {
            Transition.run(lblTaskTitle, "ForeColor", Color.DarkRed, new TransitionType_Flash(500, 500));
        }

        #endregion

        #region Events

        private void btnReminded_Click(object sender, EventArgs e)
        {
            ToDoDashboard.alarmTimer.Start();
            Todo_s.taskListBinding.ResetBindings(false);
            player.Stop();
            Dispose();
        }

        #endregion
    }
}
