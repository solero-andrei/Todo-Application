namespace TodoAppDemo
{
    partial class AddTask
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTask = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.switchAlarm = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.listSound = new System.Windows.Forms.ListBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnPreview = new System.Windows.Forms.Button();
            this.linkStopAudio = new System.Windows.Forms.LinkLabel();
            this.timeReminder = new System.Windows.Forms.DateTimePicker();
            this.timeElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblNote = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAddSound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Task Title:";
            // 
            // txtTask
            // 
            this.txtTask.BorderRadius = 5;
            this.txtTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTask.DefaultText = "";
            this.txtTask.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTask.DisabledState.Parent = this.txtTask;
            this.txtTask.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTask.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTask.FocusedState.Parent = this.txtTask;
            this.txtTask.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTask.ForeColor = System.Drawing.Color.DimGray;
            this.txtTask.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTask.HoverState.Parent = this.txtTask;
            this.txtTask.Location = new System.Drawing.Point(33, 34);
            this.txtTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTask.Name = "txtTask";
            this.txtTask.PasswordChar = '\0';
            this.txtTask.PlaceholderText = "Task Title...";
            this.txtTask.SelectedText = "";
            this.txtTask.ShadowDecoration.Parent = this.txtTask;
            this.txtTask.Size = new System.Drawing.Size(365, 38);
            this.txtTask.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Remind me on this Time:";
            // 
            // switchAlarm
            // 
            this.switchAlarm.Animated = true;
            this.switchAlarm.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchAlarm.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.switchAlarm.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchAlarm.CheckedState.InnerColor = System.Drawing.Color.White;
            this.switchAlarm.CheckedState.Parent = this.switchAlarm;
            this.switchAlarm.Location = new System.Drawing.Point(311, 83);
            this.switchAlarm.Name = "switchAlarm";
            this.switchAlarm.ShadowDecoration.Parent = this.switchAlarm;
            this.switchAlarm.Size = new System.Drawing.Size(35, 20);
            this.switchAlarm.TabIndex = 20;
            this.switchAlarm.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchAlarm.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.switchAlarm.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.switchAlarm.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.switchAlarm.UncheckedState.Parent = this.switchAlarm;
            this.switchAlarm.CheckedChanged += new System.EventHandler(this.switchAlarm_CheckedChanged);
            this.switchAlarm.Click += new System.EventHandler(this.switchAlarm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(259, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Alarm:";
            // 
            // listSound
            // 
            this.listSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(0)))), ((int)(((byte)(56)))));
            this.listSound.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listSound.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSound.ForeColor = System.Drawing.Color.White;
            this.listSound.FormattingEnabled = true;
            this.listSound.HorizontalScrollbar = true;
            this.listSound.ItemHeight = 15;
            this.listSound.Location = new System.Drawing.Point(228, 129);
            this.listSound.Name = "listSound";
            this.listSound.Size = new System.Drawing.Size(170, 75);
            this.listSound.TabIndex = 22;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 7;
            this.guna2Elipse2.TargetControl = this.listSound;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(228, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Choose your sound Alarm:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(46, 156);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(152, 43);
            this.btnCreate.TabIndex = 25;
            this.btnCreate.Text = "Create Task";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 7;
            this.guna2Elipse1.TargetControl = this.btnCreate;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.FlatAppearance.BorderSize = 0;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(323, 208);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 26;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // linkStopAudio
            // 
            this.linkStopAudio.AutoSize = true;
            this.linkStopAudio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkStopAudio.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkStopAudio.Location = new System.Drawing.Point(250, 211);
            this.linkStopAudio.Name = "linkStopAudio";
            this.linkStopAudio.Size = new System.Drawing.Size(67, 16);
            this.linkStopAudio.TabIndex = 27;
            this.linkStopAudio.TabStop = true;
            this.linkStopAudio.Text = "Stop Audio";
            this.linkStopAudio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStopAudio_LinkClicked);
            // 
            // timeReminder
            // 
            this.timeReminder.CalendarForeColor = System.Drawing.Color.Black;
            this.timeReminder.CalendarMonthBackground = System.Drawing.Color.White;
            this.timeReminder.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.timeReminder.CustomFormat = "hh:mm tt";
            this.timeReminder.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeReminder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeReminder.Location = new System.Drawing.Point(40, 107);
            this.timeReminder.Name = "timeReminder";
            this.timeReminder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeReminder.ShowUpDown = true;
            this.timeReminder.Size = new System.Drawing.Size(165, 43);
            this.timeReminder.TabIndex = 28;
            // 
            // timeElipse
            // 
            this.timeElipse.BorderRadius = 15;
            this.timeElipse.TargetControl = this.timeReminder;
            // 
            // lblNote
            // 
            this.lblNote.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(30, 202);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(175, 32);
            this.lblNote.TabIndex = 29;
            this.lblNote.Text = "Note: Time reminder must be greater than the current time";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(348, 85);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(27, 17);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "On";
            // 
            // btnAddSound
            // 
            this.btnAddSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSound.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSound.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSound.ForeColor = System.Drawing.Color.White;
            this.btnAddSound.Location = new System.Drawing.Point(401, 178);
            this.btnAddSound.Name = "btnAddSound";
            this.btnAddSound.Size = new System.Drawing.Size(18, 23);
            this.btnAddSound.TabIndex = 31;
            this.btnAddSound.Tag = "";
            this.btnAddSound.Text = "+";
            this.btnAddSound.UseVisualStyleBackColor = true;
            this.btnAddSound.Click += new System.EventHandler(this.btnAddSound_Click);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAddSound);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.timeReminder);
            this.Controls.Add(this.linkStopAudio);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listSound);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.switchAlarm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.label1);
            this.Name = "AddTask";
            this.Size = new System.Drawing.Size(426, 243);
            this.Load += new System.EventHandler(this.AddTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTask;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch switchAlarm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listSound;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreate;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.LinkLabel linkStopAudio;
        private System.Windows.Forms.DateTimePicker timeReminder;
        private Guna.UI2.WinForms.Guna2Elipse timeElipse;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAddSound;
    }
}
