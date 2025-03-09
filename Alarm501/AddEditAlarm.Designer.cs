namespace Alarm501
{
    partial class AddEditAlarm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.UXSetAlarmBtn = new System.Windows.Forms.Button();
            this.UxCancelEditAlarmBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.UxAlarmSoundSet = new System.Windows.Forms.ComboBox();
            this.UxRepeatingSchedulesCheck = new System.Windows.Forms.CheckBox();
            this.UxRepeatingScheduleDays = new System.Windows.Forms.CheckedListBox();
            this.UxAlarmName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 48);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2021, 1, 29, 22, 30, 0, 0);
            // 
            // UXSetAlarmBtn
            // 
            this.UXSetAlarmBtn.Location = new System.Drawing.Point(190, 237);
            this.UXSetAlarmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UXSetAlarmBtn.Name = "UXSetAlarmBtn";
            this.UXSetAlarmBtn.Size = new System.Drawing.Size(57, 30);
            this.UXSetAlarmBtn.TabIndex = 1;
            this.UXSetAlarmBtn.Text = "Set";
            this.UXSetAlarmBtn.UseVisualStyleBackColor = true;
            this.UXSetAlarmBtn.Click += new System.EventHandler(this.UXSetAlarmBtn_Click);
            // 
            // UxCancelEditAlarmBtn
            // 
            this.UxCancelEditAlarmBtn.Location = new System.Drawing.Point(28, 237);
            this.UxCancelEditAlarmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UxCancelEditAlarmBtn.Name = "UxCancelEditAlarmBtn";
            this.UxCancelEditAlarmBtn.Size = new System.Drawing.Size(57, 30);
            this.UxCancelEditAlarmBtn.TabIndex = 2;
            this.UxCancelEditAlarmBtn.Text = "Cancel";
            this.UxCancelEditAlarmBtn.UseVisualStyleBackColor = true;
            this.UxCancelEditAlarmBtn.Click += new System.EventHandler(this.UxCancelEditAlarmBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(190, 48);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(40, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "On";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // UxAlarmSoundSet
            // 
            this.UxAlarmSoundSet.FormattingEnabled = true;
            this.UxAlarmSoundSet.Location = new System.Drawing.Point(28, 73);
            this.UxAlarmSoundSet.Name = "UxAlarmSoundSet";
            this.UxAlarmSoundSet.Size = new System.Drawing.Size(121, 21);
            this.UxAlarmSoundSet.TabIndex = 4;
            // 
            // UxRepeatingSchedulesCheck
            // 
            this.UxRepeatingSchedulesCheck.AutoSize = true;
            this.UxRepeatingSchedulesCheck.Location = new System.Drawing.Point(28, 100);
            this.UxRepeatingSchedulesCheck.Name = "UxRepeatingSchedulesCheck";
            this.UxRepeatingSchedulesCheck.Size = new System.Drawing.Size(123, 17);
            this.UxRepeatingSchedulesCheck.TabIndex = 5;
            this.UxRepeatingSchedulesCheck.Text = "Repeating Schedule";
            this.UxRepeatingSchedulesCheck.UseVisualStyleBackColor = true;
            this.UxRepeatingSchedulesCheck.CheckedChanged += new System.EventHandler(this.UxRepeatingSchedulesCheck_CheckedChanged);
            // 
            // UxRepeatingScheduleDays
            // 
            this.UxRepeatingScheduleDays.Enabled = false;
            this.UxRepeatingScheduleDays.FormattingEnabled = true;
            this.UxRepeatingScheduleDays.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.UxRepeatingScheduleDays.Location = new System.Drawing.Point(31, 123);
            this.UxRepeatingScheduleDays.Name = "UxRepeatingScheduleDays";
            this.UxRepeatingScheduleDays.Size = new System.Drawing.Size(120, 109);
            this.UxRepeatingScheduleDays.TabIndex = 6;
            this.UxRepeatingScheduleDays.SelectedValueChanged += new System.EventHandler(this.UxRepeatingScheduleDays_SelectedValueChanged);
            // 
            // UxAlarmName
            // 
            this.UxAlarmName.Location = new System.Drawing.Point(28, 23);
            this.UxAlarmName.Name = "UxAlarmName";
            this.UxAlarmName.Size = new System.Drawing.Size(202, 20);
            this.UxAlarmName.TabIndex = 7;
            this.UxAlarmName.Text = "Alarm Name (optional)";
            // 
            // AddEditAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 278);
            this.Controls.Add(this.UxAlarmName);
            this.Controls.Add(this.UxRepeatingScheduleDays);
            this.Controls.Add(this.UxRepeatingSchedulesCheck);
            this.Controls.Add(this.UxAlarmSoundSet);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.UxCancelEditAlarmBtn);
            this.Controls.Add(this.UXSetAlarmBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEditAlarm";
            this.Text = "Add/Edit Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button UXSetAlarmBtn;
        private System.Windows.Forms.Button UxCancelEditAlarmBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox UxAlarmSoundSet;
        private System.Windows.Forms.CheckBox UxRepeatingSchedulesCheck;
        private System.Windows.Forms.CheckedListBox UxRepeatingScheduleDays;
        private System.Windows.Forms.TextBox UxAlarmName;
    }
}