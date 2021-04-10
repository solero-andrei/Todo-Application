namespace TodoAppDemo
{
    partial class TaskAlarm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReminded = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.colorTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTaskTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TodoAppDemo.Properties.Resources.animated_alarm_clock_image_0005;
            this.pictureBox1.Location = new System.Drawing.Point(294, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnReminded
            // 
            this.btnReminded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReminded.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReminded.FlatAppearance.BorderSize = 0;
            this.btnReminded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReminded.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReminded.ForeColor = System.Drawing.Color.White;
            this.btnReminded.Location = new System.Drawing.Point(294, 95);
            this.btnReminded.Name = "btnReminded";
            this.btnReminded.Size = new System.Drawing.Size(125, 31);
            this.btnReminded.TabIndex = 26;
            this.btnReminded.Text = "I\'m Reminded";
            this.btnReminded.UseVisualStyleBackColor = false;
            this.btnReminded.Click += new System.EventHandler(this.btnReminded_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.btnReminded;
            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskTitle.ForeColor = System.Drawing.Color.White;
            this.lblTaskTitle.Location = new System.Drawing.Point(12, 4);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(276, 122);
            this.lblTaskTitle.TabIndex = 27;
            this.lblTaskTitle.Text = "label1";
            this.lblTaskTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(431, 135);
            this.Controls.Add(this.lblTaskTitle);
            this.Controls.Add(this.btnReminded);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskAlarm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TaskAlarm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReminded;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Timer colorTimer;
        private System.Windows.Forms.Label lblTaskTitle;
    }
}