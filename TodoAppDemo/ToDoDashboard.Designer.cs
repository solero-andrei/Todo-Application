namespace TodoAppDemo
{
    partial class ToDoDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoDashboard));
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.FormDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblTitleText = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblListCounter = new System.Windows.Forms.Label();
            this.btnExpand = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnMenu = new XanderUI.XUISegment();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.menuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.listCounterTimer = new System.Windows.Forms.Timer(this.components);
            this.todo_s1 = new TodoAppDemo.Todo_s();
            this.addTask1 = new TodoAppDemo.AddTask();
            this.bunifuGradientPanel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // formElipse
            // 
            this.formElipse.BorderRadius = 7;
            this.formElipse.TargetControl = this;
            // 
            // FormDragControl
            // 
            this.FormDragControl.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lblTitleText);
            this.bunifuGradientPanel1.Controls.Add(this.lblTitle);
            this.bunifuGradientPanel1.Controls.Add(this.btnMinimize);
            this.bunifuGradientPanel1.Controls.Add(this.lblListCounter);
            this.bunifuGradientPanel1.Controls.Add(this.btnExpand);
            this.bunifuGradientPanel1.Controls.Add(this.mainPanel);
            this.bunifuGradientPanel1.Controls.Add(this.btnMenu);
            this.bunifuGradientPanel1.Controls.Add(this.lblDate);
            this.bunifuGradientPanel1.Controls.Add(this.lblTime);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(450, 430);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // lblTitleText
            // 
            this.lblTitleText.AutoSize = true;
            this.lblTitleText.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleText.ForeColor = System.Drawing.Color.White;
            this.lblTitleText.Location = new System.Drawing.Point(9, 29);
            this.lblTitleText.Name = "lblTitleText";
            this.lblTitleText.Size = new System.Drawing.Size(224, 16);
            this.lblTitleText.TabIndex = 9;
            this.lblTitleText.Text = "Your all day todo list that will remind you";
            this.lblTitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(7, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(121, 27);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "All Day List";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Animated = true;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(414, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(24, 24);
            this.btnMinimize.TabIndex = 7;
            // 
            // lblListCounter
            // 
            this.lblListCounter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCounter.ForeColor = System.Drawing.Color.White;
            this.lblListCounter.Location = new System.Drawing.Point(69, 106);
            this.lblListCounter.Name = "lblListCounter";
            this.lblListCounter.Size = new System.Drawing.Size(312, 19);
            this.lblListCounter.TabIndex = 6;
            this.lblListCounter.Text = "label2";
            this.lblListCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblListCounter.Visible = false;
            // 
            // btnExpand
            // 
            this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpand.Location = new System.Drawing.Point(411, 95);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(27, 30);
            this.btnExpand.TabIndex = 5;
            this.btnExpand.Text = "v";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.todo_s1);
            this.mainPanel.Controls.Add(this.addTask1);
            this.mainPanel.Location = new System.Drawing.Point(12, 176);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(426, 243);
            this.mainPanel.TabIndex = 4;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Items = "Todo\'s, Add Task";
            this.btnMenu.Location = new System.Drawing.Point(12, 128);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.SegmentActiveTextColor = System.Drawing.Color.White;
            this.btnMenu.SegmentBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.SegmentColor = System.Drawing.Color.GhostWhite;
            this.btnMenu.SegmentInactiveTextColor = System.Drawing.Color.DimGray;
            this.btnMenu.SegmentStyle = XanderUI.XUISegment.Style.Material;
            this.btnMenu.SelectedIndex = 0;
            this.btnMenu.Size = new System.Drawing.Size(426, 42);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "xuiSegment1";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDate.Location = new System.Drawing.Point(62, 86);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(110, 21);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Current Time";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(55, 50);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(232, 42);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Current Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // menuElipse
            // 
            this.menuElipse.ElipseRadius = 10;
            this.menuElipse.TargetControl = this.btnMenu;
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // listCounterTimer
            // 
            this.listCounterTimer.Interval = 3000;
            this.listCounterTimer.Tick += new System.EventHandler(this.listCounterTimer_Tick);
            // 
            // todo_s1
            // 
            this.todo_s1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(0)))), ((int)(((byte)(56)))));
            this.todo_s1.Location = new System.Drawing.Point(0, 0);
            this.todo_s1.Name = "todo_s1";
            this.todo_s1.Size = new System.Drawing.Size(426, 243);
            this.todo_s1.TabIndex = 0;
            // 
            // addTask1
            // 
            this.addTask1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(0)))), ((int)(((byte)(56)))));
            this.addTask1.Location = new System.Drawing.Point(0, 0);
            this.addTask1.Name = "addTask1";
            this.addTask1.Size = new System.Drawing.Size(426, 243);
            this.addTask1.TabIndex = 10;
            // 
            // ToDoDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(450, 430);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToDoDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Day List";
            this.TopMost = true;
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private Guna.UI2.WinForms.Guna2DragControl FormDragControl;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private XanderUI.XUISegment btnMenu;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Label lblListCounter;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Bunifu.Framework.UI.BunifuElipse menuElipse;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleText;
        private System.Windows.Forms.Timer listCounterTimer;
        private Todo_s todo_s1;
        private AddTask addTask1;
    }
}