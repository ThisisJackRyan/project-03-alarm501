namespace Alarm501
{
    partial class AlarmGoingOff
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
            this.UxSnoozeButton = new System.Windows.Forms.Button();
            this.UxTurnOffButton = new System.Windows.Forms.Button();
            this.UxAlarmName = new System.Windows.Forms.Label();
            this.UxAlarmTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UxAlarmSound = new System.Windows.Forms.Label();
            this.UxSnoozeAmount = new System.Windows.Forms.NumericUpDown();
            this.UxSnoozeText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UxSnoozeAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // UxSnoozeButton
            // 
            this.UxSnoozeButton.Location = new System.Drawing.Point(12, 210);
            this.UxSnoozeButton.Name = "UxSnoozeButton";
            this.UxSnoozeButton.Size = new System.Drawing.Size(75, 23);
            this.UxSnoozeButton.TabIndex = 0;
            this.UxSnoozeButton.Text = "Snooze";
            this.UxSnoozeButton.UseVisualStyleBackColor = true;
            this.UxSnoozeButton.Click += new System.EventHandler(this.UxSnoozeButton_Click);
            // 
            // UxTurnOffButton
            // 
            this.UxTurnOffButton.Location = new System.Drawing.Point(167, 210);
            this.UxTurnOffButton.Name = "UxTurnOffButton";
            this.UxTurnOffButton.Size = new System.Drawing.Size(75, 23);
            this.UxTurnOffButton.TabIndex = 1;
            this.UxTurnOffButton.Text = "Turn Off";
            this.UxTurnOffButton.UseVisualStyleBackColor = true;
            this.UxTurnOffButton.Click += new System.EventHandler(this.UxTurnOffButton_Click);
            // 
            // UxAlarmName
            // 
            this.UxAlarmName.AutoSize = true;
            this.UxAlarmName.Location = new System.Drawing.Point(21, 31);
            this.UxAlarmName.Name = "UxAlarmName";
            this.UxAlarmName.Size = new System.Drawing.Size(60, 13);
            this.UxAlarmName.TabIndex = 2;
            this.UxAlarmName.Text = "Your alarm:";
            // 
            // UxAlarmTime
            // 
            this.UxAlarmTime.AutoSize = true;
            this.UxAlarmTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UxAlarmTime.Location = new System.Drawing.Point(20, 56);
            this.UxAlarmTime.Name = "UxAlarmTime";
            this.UxAlarmTime.Size = new System.Drawing.Size(115, 20);
            this.UxAlarmTime.TabIndex = 3;
            this.UxAlarmTime.Text = "(alarm.tostring)";
            this.UxAlarmTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "is going off with sound";
            // 
            // UxAlarmSound
            // 
            this.UxAlarmSound.AutoSize = true;
            this.UxAlarmSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UxAlarmSound.Location = new System.Drawing.Point(23, 114);
            this.UxAlarmSound.Name = "UxAlarmSound";
            this.UxAlarmSound.Size = new System.Drawing.Size(102, 20);
            this.UxAlarmSound.TabIndex = 5;
            this.UxAlarmSound.Text = "(alarmsound)";
            // 
            // UxSnoozeAmount
            // 
            this.UxSnoozeAmount.Location = new System.Drawing.Point(15, 184);
            this.UxSnoozeAmount.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.UxSnoozeAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UxSnoozeAmount.Name = "UxSnoozeAmount";
            this.UxSnoozeAmount.Size = new System.Drawing.Size(120, 20);
            this.UxSnoozeAmount.TabIndex = 6;
            this.UxSnoozeAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UxSnoozeText
            // 
            this.UxSnoozeText.AutoSize = true;
            this.UxSnoozeText.Location = new System.Drawing.Point(12, 168);
            this.UxSnoozeText.Name = "UxSnoozeText";
            this.UxSnoozeText.Size = new System.Drawing.Size(106, 13);
            this.UxSnoozeText.TabIndex = 7;
            this.UxSnoozeText.Text = "Snooze for: (minutes)";
            // 
            // AlarmGoingOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 245);
            this.Controls.Add(this.UxSnoozeText);
            this.Controls.Add(this.UxSnoozeAmount);
            this.Controls.Add(this.UxAlarmSound);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UxAlarmTime);
            this.Controls.Add(this.UxAlarmName);
            this.Controls.Add(this.UxTurnOffButton);
            this.Controls.Add(this.UxSnoozeButton);
            this.Name = "AlarmGoingOff";
            this.Text = "Alarm";
            ((System.ComponentModel.ISupportInitialize)(this.UxSnoozeAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UxSnoozeButton;
        private System.Windows.Forms.Button UxTurnOffButton;
        private System.Windows.Forms.Label UxAlarmName;
        private System.Windows.Forms.Label UxAlarmTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UxAlarmSound;
        private System.Windows.Forms.NumericUpDown UxSnoozeAmount;
        private System.Windows.Forms.Label UxSnoozeText;
    }
}