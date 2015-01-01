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
            this.addTimerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTimerButton
            // 
            this.addTimerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTimerButton.Location = new System.Drawing.Point(12, 12);
            this.addTimerButton.Name = "addTimerButton";
            this.addTimerButton.Size = new System.Drawing.Size(30, 30);
            this.addTimerButton.TabIndex = 0;
            this.addTimerButton.Text = "+";
            this.addTimerButton.UseVisualStyleBackColor = true;
            this.addTimerButton.Click += new System.EventHandler(this.addTimerButton_Click);
            // 
            // TimerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.addTimerButton);
            this.MinimizeBox = false;
            this.Name = "TimerHome";
            this.Text = "Timer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTimerButton;
    }
}