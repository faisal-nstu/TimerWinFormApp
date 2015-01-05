﻿namespace TimerWinFormApp.UI
{
    partial class TimerHome
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
            this.addTimerButton = new System.Windows.Forms.Button();
            this.hourInputTextbox = new System.Windows.Forms.TextBox();
            this.minuteInputTextbox = new System.Windows.Forms.TextBox();
            this.secondInputTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // addTimerButton
            // 
            this.addTimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTimerButton.ForeColor = System.Drawing.Color.DimGray;
            this.addTimerButton.Location = new System.Drawing.Point(12, 85);
            this.addTimerButton.Name = "addTimerButton";
            this.addTimerButton.Size = new System.Drawing.Size(60, 40);
            this.addTimerButton.TabIndex = 0;
            this.addTimerButton.Text = "+";
            this.addTimerButton.UseVisualStyleBackColor = true;
            this.addTimerButton.Click += new System.EventHandler(this.addTimerButton_Click);
            // 
            // hourInputTextbox
            // 
            this.hourInputTextbox.BackColor = System.Drawing.Color.Gainsboro;
            this.hourInputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hourInputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourInputTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.hourInputTextbox.Location = new System.Drawing.Point(12, 39);
            this.hourInputTextbox.MinimumSize = new System.Drawing.Size(0, 40);
            this.hourInputTextbox.Name = "hourInputTextbox";
            this.hourInputTextbox.Size = new System.Drawing.Size(60, 40);
            this.hourInputTextbox.TabIndex = 1;
            this.hourInputTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minuteInputTextbox
            // 
            this.minuteInputTextbox.BackColor = System.Drawing.Color.Gainsboro;
            this.minuteInputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minuteInputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteInputTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.minuteInputTextbox.Location = new System.Drawing.Point(89, 39);
            this.minuteInputTextbox.MinimumSize = new System.Drawing.Size(0, 40);
            this.minuteInputTextbox.Name = "minuteInputTextbox";
            this.minuteInputTextbox.Size = new System.Drawing.Size(60, 40);
            this.minuteInputTextbox.TabIndex = 2;
            this.minuteInputTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondInputTextbox
            // 
            this.secondInputTextbox.BackColor = System.Drawing.Color.Gainsboro;
            this.secondInputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondInputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondInputTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.secondInputTextbox.Location = new System.Drawing.Point(166, 39);
            this.secondInputTextbox.MinimumSize = new System.Drawing.Size(0, 40);
            this.secondInputTextbox.Name = "secondInputTextbox";
            this.secondInputTextbox.Size = new System.Drawing.Size(60, 40);
            this.secondInputTextbox.TabIndex = 3;
            this.secondInputTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(67, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(144, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.DimGray;
            this.startButton.Location = new System.Drawing.Point(88, 85);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(60, 40);
            this.startButton.TabIndex = 4;
            this.startButton.Text = ">";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.ForeColor = System.Drawing.Color.DimGray;
            this.pauseButton.Location = new System.Drawing.Point(166, 85);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(60, 40);
            this.pauseButton.TabIndex = 5;
            this.pauseButton.Text = "ll";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Gainsboro;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(210, -1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(29, 23);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Gainsboro;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(178, -1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(29, 23);
            this.minimizeButton.TabIndex = 6;
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(70, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "TIMER";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // TimerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 140);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.secondInputTextbox);
            this.Controls.Add(this.minuteInputTextbox);
            this.Controls.Add(this.hourInputTextbox);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.addTimerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTimerButton;
        private System.Windows.Forms.TextBox hourInputTextbox;
        private System.Windows.Forms.TextBox minuteInputTextbox;
        private System.Windows.Forms.TextBox secondInputTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}