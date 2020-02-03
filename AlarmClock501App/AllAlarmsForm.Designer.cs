namespace AlarmClock501App
{
    partial class AllAlarmsForm
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
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SnoozeButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.AllAlarms = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(38, 28);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 0;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(208, 28);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SnoozeButton
            // 
            this.SnoozeButton.Enabled = false;
            this.SnoozeButton.Location = new System.Drawing.Point(38, 346);
            this.SnoozeButton.Name = "SnoozeButton";
            this.SnoozeButton.Size = new System.Drawing.Size(75, 23);
            this.SnoozeButton.TabIndex = 2;
            this.SnoozeButton.Text = "Snooze";
            this.SnoozeButton.UseVisualStyleBackColor = true;
            this.SnoozeButton.Click += new System.EventHandler(this.SnoozeButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(208, 346);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // AllAlarms
            // 
            this.AllAlarms.FormattingEnabled = true;
            this.AllAlarms.ItemHeight = 16;
            this.AllAlarms.Location = new System.Drawing.Point(62, 98);
            this.AllAlarms.Name = "AllAlarms";
            this.AllAlarms.Size = new System.Drawing.Size(192, 212);
            this.AllAlarms.TabIndex = 4;
            this.AllAlarms.SelectedIndexChanged += new System.EventHandler(this.AllAlarms_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // AllAlarmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllAlarms);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.SnoozeButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Name = "AllAlarmsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SnoozeButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ListBox AllAlarms;
        private System.Windows.Forms.Label label1;
    }
}

