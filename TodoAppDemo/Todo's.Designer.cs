namespace TodoAppDemo
{
    partial class Todo_s
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
            this.taskList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaskDone = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskList
            // 
            this.taskList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.taskList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskList.ForeColor = System.Drawing.Color.White;
            this.taskList.FormattingEnabled = true;
            this.taskList.HorizontalScrollbar = true;
            this.taskList.ItemHeight = 17;
            this.taskList.Location = new System.Drawing.Point(19, 19);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(391, 104);
            this.taskList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Todo\'s";
            // 
            // btnTaskDone
            // 
            this.btnTaskDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTaskDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaskDone.FlatAppearance.BorderSize = 0;
            this.btnTaskDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskDone.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskDone.ForeColor = System.Drawing.Color.White;
            this.btnTaskDone.Location = new System.Drawing.Point(221, 173);
            this.btnTaskDone.Name = "btnTaskDone";
            this.btnTaskDone.Size = new System.Drawing.Size(171, 51);
            this.btnTaskDone.TabIndex = 26;
            this.btnTaskDone.Text = "Task Done";
            this.btnTaskDone.UseVisualStyleBackColor = false;
            this.btnTaskDone.Click += new System.EventHandler(this.btnTaskDone_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(219, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Choose and click task done to \r\nremove mark it as done.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 84);
            this.label2.TabIndex = 28;
            this.label2.Text = "-(DONE) - The task is \r\nalready done by you.\r\n\r\n-(REMINDED) - The task\r\nis not do" +
    "ne yet, but we \r\nreminded you.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "LEGEND:";
            // 
            // Todo_s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTaskDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskList);
            this.Name = "Todo_s";
            this.Size = new System.Drawing.Size(426, 243);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox taskList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaskDone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
