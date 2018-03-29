namespace MovingObject
{
    partial class MainForm
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
            this.Canvas = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.GetColor = new System.Windows.Forms.ColorDialog();
            this.AboutButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SpeedList = new System.Windows.Forms.ComboBox();
            this.ShapesList = new System.Windows.Forms.ComboBox();
            this.BackgroundColorButton = new System.Windows.Forms.Button();
            this.InnerColorButton = new System.Windows.Forms.Button();
            this.OutlineColorButton = new System.Windows.Forms.Button();
            this.ApplicationStatus = new System.Windows.Forms.StatusStrip();
            this.CurrentActionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Shortcuts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationStatus.SuspendLayout();
            this.Shortcuts.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Location = new System.Drawing.Point(12, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(866, 536);
            this.Canvas.TabIndex = 0;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.Location = new System.Drawing.Point(945, 515);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(191, 33);
            this.AboutButton.TabIndex = 2;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.StopButton.Location = new System.Drawing.Point(945, 82);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(191, 33);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.StartButton.Location = new System.Drawing.Point(945, 22);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(191, 33);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SpeedList
            // 
            this.SpeedList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpeedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SpeedList.FormattingEnabled = true;
            this.SpeedList.Items.AddRange(new object[] {
            "Slow",
            "Normal",
            "Fast"});
            this.SpeedList.Location = new System.Drawing.Point(945, 383);
            this.SpeedList.Name = "SpeedList";
            this.SpeedList.Size = new System.Drawing.Size(191, 30);
            this.SpeedList.TabIndex = 5;
            this.SpeedList.SelectedIndexChanged += new System.EventHandler(this.SpeedList_SelectedIndexChanged);
            // 
            // ShapesList
            // 
            this.ShapesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShapesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ShapesList.FormattingEnabled = true;
            this.ShapesList.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Rectangle"});
            this.ShapesList.Location = new System.Drawing.Point(945, 326);
            this.ShapesList.Name = "ShapesList";
            this.ShapesList.Size = new System.Drawing.Size(191, 30);
            this.ShapesList.TabIndex = 6;
            this.ShapesList.SelectedIndexChanged += new System.EventHandler(this.ShapesList_SelectedIndexChanged);
            // 
            // BackgroundColorButton
            // 
            this.BackgroundColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BackgroundColorButton.Location = new System.Drawing.Point(945, 269);
            this.BackgroundColorButton.Name = "BackgroundColorButton";
            this.BackgroundColorButton.Size = new System.Drawing.Size(191, 33);
            this.BackgroundColorButton.TabIndex = 7;
            this.BackgroundColorButton.Text = "Background Color:";
            this.BackgroundColorButton.UseVisualStyleBackColor = true;
            this.BackgroundColorButton.Click += new System.EventHandler(this.BackgroundColorButton_Click);
            // 
            // InnerColorButton
            // 
            this.InnerColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.InnerColorButton.Location = new System.Drawing.Point(945, 148);
            this.InnerColorButton.Name = "InnerColorButton";
            this.InnerColorButton.Size = new System.Drawing.Size(191, 33);
            this.InnerColorButton.TabIndex = 8;
            this.InnerColorButton.Text = "Inner Color:";
            this.InnerColorButton.UseVisualStyleBackColor = true;
            this.InnerColorButton.Click += new System.EventHandler(this.InnerColorButton_Click);
            // 
            // OutlineColorButton
            // 
            this.OutlineColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.OutlineColorButton.Location = new System.Drawing.Point(945, 209);
            this.OutlineColorButton.Name = "OutlineColorButton";
            this.OutlineColorButton.Size = new System.Drawing.Size(191, 33);
            this.OutlineColorButton.TabIndex = 9;
            this.OutlineColorButton.Text = "Outline Color:";
            this.OutlineColorButton.UseVisualStyleBackColor = true;
            this.OutlineColorButton.Click += new System.EventHandler(this.OutlineColorButton_Click);
            // 
            // ApplicationStatus
            // 
            this.ApplicationStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ApplicationStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentActionLabel});
            this.ApplicationStatus.Location = new System.Drawing.Point(0, 570);
            this.ApplicationStatus.Name = "ApplicationStatus";
            this.ApplicationStatus.Size = new System.Drawing.Size(1156, 22);
            this.ApplicationStatus.TabIndex = 10;
            this.ApplicationStatus.Text = "statusStrip2";
            // 
            // CurrentActionLabel
            // 
            this.CurrentActionLabel.Name = "CurrentActionLabel";
            this.CurrentActionLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Shortcuts
            // 
            this.Shortcuts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Shortcuts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.Shortcuts.Name = "Shortcuts";
            this.Shortcuts.Size = new System.Drawing.Size(176, 80);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 592);
            this.Controls.Add(this.ApplicationStatus);
            this.Controls.Add(this.BackgroundColorButton);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.OutlineColorButton);
            this.Controls.Add(this.SpeedList);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.ShapesList);
            this.Controls.Add(this.InnerColorButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ApplicationStatus.ResumeLayout(false);
            this.ApplicationStatus.PerformLayout();
            this.Shortcuts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ColorDialog GetColor;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ComboBox SpeedList;
        private System.Windows.Forms.ComboBox ShapesList;
        private System.Windows.Forms.Button BackgroundColorButton;
        private System.Windows.Forms.Button InnerColorButton;
        private System.Windows.Forms.Button OutlineColorButton;
        private System.Windows.Forms.StatusStrip ApplicationStatus;
        private System.Windows.Forms.ToolStripStatusLabel CurrentActionLabel;
        private System.Windows.Forms.ContextMenuStrip Shortcuts;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
    }
}

