﻿namespace AlarmClock501App
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
            this.SnoozeButton.Location = new System.Drawing.Point(21, 366);
            this.SnoozeButton.Name = "SnoozeButton";
            this.SnoozeButton.Size = new System.Drawing.Size(75, 23);
            this.SnoozeButton.TabIndex = 2;
            this.SnoozeButton.Text = "Snooze";
            this.SnoozeButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(208, 366);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // AllAlarms
            // 
            this.AllAlarms.FormattingEnabled = true;
            this.AllAlarms.ItemHeight = 16;
            this.AllAlarms.Location = new System.Drawing.Point(62, 98);
            this.AllAlarms.Name = "AllAlarms";
            this.AllAlarms.Size = new System.Drawing.Size(957, 212);
            this.AllAlarms.TabIndex = 4;
            // 
            // AllAlarmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 450);
            this.Controls.Add(this.AllAlarms);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.SnoozeButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Name = "AllAlarmsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SnoozeButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ListBox AllAlarms;
    }
}

