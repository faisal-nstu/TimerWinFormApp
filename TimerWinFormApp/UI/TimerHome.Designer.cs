namespace TimerWinFormApp.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerHome));
            this.addTimerButton = new System.Windows.Forms.Button();
            this.hourInputTextbox = new System.Windows.Forms.TextBox();
            this.minuteInputTextbox = new System.Windows.Forms.TextBox();
            this.secondInputTextbox = new System.Windows.Forms.TextBox();
            this.colonLabel1 = new System.Windows.Forms.Label();
            this.colonLabel2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.alertMsgTextbox = new System.Windows.Forms.TextBox();
            this.titlebarLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.titlebarLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // addTimerButton
            // 
            this.addTimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTimerButton.ForeColor = System.Drawing.Color.DimGray;
            this.addTimerButton.Location = new System.Drawing.Point(13, 33);
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
            this.hourInputTextbox.Location = new System.Drawing.Point(12, 79);
            this.hourInputTextbox.MinimumSize = new System.Drawing.Size(0, 40);
            this.hourInputTextbox.Name = "hourInputTextbox";
            this.hourInputTextbox.Size = new System.Drawing.Size(60, 38);
            this.hourInputTextbox.TabIndex = 1;
            this.hourInputTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minuteInputTextbox
            // 
            this.minuteInputTextbox.BackColor = System.Drawing.Color.Gainsboro;
            this.minuteInputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minuteInputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteInputTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.minuteInputTextbox.Location = new System.Drawing.Point(89, 79);
            this.minuteInputTextbox.MinimumSize = new System.Drawing.Size(0, 40);
            this.minuteInputTextbox.Name = "minuteInputTextbox";
            this.minuteInputTextbox.Size = new System.Drawing.Size(60, 38);
            this.minuteInputTextbox.TabIndex = 2;
            this.minuteInputTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondInputTextbox
            // 
            this.secondInputTextbox.BackColor = System.Drawing.Color.Gainsboro;
            this.secondInputTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondInputTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondInputTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.secondInputTextbox.Location = new System.Drawing.Point(166, 79);
            this.secondInputTextbox.MinimumSize = new System.Drawing.Size(0, 40);
            this.secondInputTextbox.Name = "secondInputTextbox";
            this.secondInputTextbox.Size = new System.Drawing.Size(60, 38);
            this.secondInputTextbox.TabIndex = 3;
            this.secondInputTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colonLabel1
            // 
            this.colonLabel1.AutoSize = true;
            this.colonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.colonLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colonLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colonLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.colonLabel1.Location = new System.Drawing.Point(67, 76);
            this.colonLabel1.Name = "colonLabel1";
            this.colonLabel1.Size = new System.Drawing.Size(27, 39);
            this.colonLabel1.TabIndex = 2;
            this.colonLabel1.Text = ":";
            // 
            // colonLabel2
            // 
            this.colonLabel2.AutoSize = true;
            this.colonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.colonLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colonLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colonLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.colonLabel2.Location = new System.Drawing.Point(144, 76);
            this.colonLabel2.Name = "colonLabel2";
            this.colonLabel2.Size = new System.Drawing.Size(27, 39);
            this.colonLabel2.TabIndex = 2;
            this.colonLabel2.Text = ":";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.DimGray;
            this.startButton.Location = new System.Drawing.Point(89, 33);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(60, 40);
            this.startButton.TabIndex = 5;
            this.startButton.Text = ">";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.ForeColor = System.Drawing.Color.DimGray;
            this.pauseButton.Location = new System.Drawing.Point(167, 33);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(60, 40);
            this.pauseButton.TabIndex = 6;
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
            this.closeButton.TabIndex = 8;
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
            this.minimizeButton.TabIndex = 7;
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
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // alertMsgTextbox
            // 
            this.alertMsgTextbox.BackColor = System.Drawing.Color.Gainsboro;
            this.alertMsgTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alertMsgTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertMsgTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.alertMsgTextbox.Location = new System.Drawing.Point(12, 33);
            this.alertMsgTextbox.MinimumSize = new System.Drawing.Size(0, 40);
            this.alertMsgTextbox.Name = "alertMsgTextbox";
            this.alertMsgTextbox.Size = new System.Drawing.Size(214, 38);
            this.alertMsgTextbox.TabIndex = 4;
            this.alertMsgTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alertMsgTextbox.Visible = false;
            // 
            // titlebarLogo
            // 
            this.titlebarLogo.Image = ((System.Drawing.Image)(resources.GetObject("titlebarLogo.Image")));
            this.titlebarLogo.Location = new System.Drawing.Point(49, 1);
            this.titlebarLogo.Name = "titlebarLogo";
            this.titlebarLogo.Size = new System.Drawing.Size(20, 20);
            this.titlebarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titlebarLogo.TabIndex = 9;
            this.titlebarLogo.TabStop = false;
            // 
            // TimerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(238, 87);
            this.Controls.Add(this.titlebarLogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.secondInputTextbox);
            this.Controls.Add(this.minuteInputTextbox);
            this.Controls.Add(this.hourInputTextbox);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.addTimerButton);
            this.Controls.Add(this.colonLabel2);
            this.Controls.Add(this.colonLabel1);
            this.Controls.Add(this.alertMsgTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)(this.titlebarLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTimerButton;
        private System.Windows.Forms.TextBox hourInputTextbox;
        private System.Windows.Forms.TextBox minuteInputTextbox;
        private System.Windows.Forms.TextBox secondInputTextbox;
        private System.Windows.Forms.Label colonLabel1;
        private System.Windows.Forms.Label colonLabel2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TextBox alertMsgTextbox;
        private System.Windows.Forms.PictureBox titlebarLogo;
    }
}