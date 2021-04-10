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
using Guna.UI2.WinForms;
using System.Globalization;
using Transitions;
using System.IO;

namespace TodoAppDemo
{
    public partial class AddTask : UserControl
    {
        public AddTask()
        {
            InitializeComponent();

            directories = new AudioDirectories();
            player = new AudioAlarm();
            soundListBinding = new BindingSource();

            soundListBinding.DataSource = AudioDirectories.AudioList;
            listSound.DataSource = soundListBinding;
            
            errorProviders.Add(new ErrorProvider { Tag = "Title Error" });
            errorProviders.Add(new ErrorProvider { Tag = "Time Error" });
            errorProviders.Add(new ErrorProvider { Tag = "Sound Error" });
        }
        
        #region Events

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTask.Text))
                {
                    errorProviders[0].SetError(txtTask, "Task title shoudn't be empty.");
                }
                else
                {
                    bool TimeValidation = Validate(timeReminder.Value);
                    if (TimeValidation == false)
                    {
                        errorProviders[2].SetError(timeReminder, lblNote.Text);
                        Transition.run(lblNote, "ForeColor", Color.DarkRed, new TransitionType_Flash(8, 300));
                    }
                    else
                    {
                        ClearError();
                        timeReminder.Value = DateTime.Now;
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                player.Play(listSound.SelectedItem.ToString());
            }
            catch
            {
                if (listSound.Items.Count < 1)
                {
                    errorProviders[2].SetError(listSound, "Please select a sound first");
                }
                else
                {
                    MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkStopAudio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            player.Stop();
        }

        private void switchAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (switchAlarm.Checked == true)
            { listSound.Enabled = true; btnPreview.Enabled = true; linkStopAudio.Enabled = true; lblStatus.Text = "On"; }
            else
            { listSound.Enabled = false; btnPreview.Enabled = false; linkStopAudio.Enabled = false; lblStatus.Text = "Off"; player.Stop(); }
        }

        private void btnAddSound_Click(object sender, EventArgs e)
        {
            AudioData();
        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            switchAlarm_CheckedChanged(sender, e);
        }

        private void switchAlarm_Click(object sender, EventArgs e)
        {
            if (listSound.Items.Count == 0)
            {
                switchAlarm.Checked = false;
                MessageBox.Show("You don't have any sound yet.\nPlease add your sound before turning on the alarm.", "Add Sound", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Transition.run(btnAddSound, "BackColor", Color.Purple, new TransitionType_Flash(5, 300));
            }
        }

        #endregion

        #region Class Fields

        AudioAlarm player;
        AudioDirectories directories;
        public static BindingSource soundListBinding { get; set; }
        List<ErrorProvider> errorProviders = new List<ErrorProvider>();

        #endregion

        #region Private Functions
        /// <summary>
        /// Method that will set all the data to the properties
        /// </summary>
        private void TaskData()
        {
            bool IsGoingToAlarm = switchAlarm.Checked == true ? true : false;
            string alarm = IsGoingToAlarm == true ? listSound.SelectedItem.ToString() : null;

            string time = timeReminder.Value.ToShortTimeString();

            TaskProcessor.TaskList.Add(new TaskProcessor { Title = txtTask.Text, AlarmTone = alarm, IsDone = false, IsGoingToAlarm = IsGoingToAlarm, TimeReminder = time, IsReminded = false });
            ToDoDashboard.alarmTimer.Start();
        }

        /// <summary>
        /// Will validate the User time if it is greater than the current time
        /// </summary>
        /// <param name="time">Will be validated</param>
        /// <returns></returns>
        private bool Validate(DateTime time)
        {
            if (time < DateTime.Now)
            {
                return false;
            }
            else
            {
                TaskData();
                player.Stop();
                txtTask.ResetText();
                switchAlarm.Checked = false;

                return true;
            }
        }

        private void AudioData()
        {
            OpenFileDialog AddSound = new OpenFileDialog { FileName = "Add Sound", Filter = "Mp3 Files(*.mp3)|*.mp3|Wav Files(*.wav)|*.wav", Title = "Browse for your sound" };
            if (AddSound.ShowDialog() == DialogResult.OK)
            {
                string path = AddSound.FileName;
                FileInfo files = new FileInfo(path);

                directories.AddAudioToFolder(files);
                soundListBinding.DataSource = AudioDirectories.AudioList;
            }
        }

        private void ClearError()
        {
            foreach (ErrorProvider providers in errorProviders)
            {
                providers.Clear();
            }
        }

        #endregion

        
    }
}
