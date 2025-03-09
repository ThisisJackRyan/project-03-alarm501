namespace Alarm501
{
    partial class Alarm501
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
            this.UxEditBtn = new System.Windows.Forms.Button();
            this.UxAddBtn = new System.Windows.Forms.Button();
            this.UxAlarmList = new System.Windows.Forms.ListBox();
            this.alarm501BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UxActiveAlarms = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alarm501BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UxEditBtn
            // 
            this.UxEditBtn.Enabled = false;
            this.UxEditBtn.Location = new System.Drawing.Point(24, 17);
            this.UxEditBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UxEditBtn.Name = "UxEditBtn";
            this.UxEditBtn.Size = new System.Drawing.Size(72, 37);
            this.UxEditBtn.TabIndex = 0;
            this.UxEditBtn.Text = "Edit";
            this.UxEditBtn.UseVisualStyleBackColor = true;
            this.UxEditBtn.Click += new System.EventHandler(this.UxEditBtn_Click);
            // 
            // UxAddBtn
            // 
            this.UxAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxAddBtn.Location = new System.Drawing.Point(144, 17);
            this.UxAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UxAddBtn.Name = "UxAddBtn";
            this.UxAddBtn.Size = new System.Drawing.Size(70, 37);
            this.UxAddBtn.TabIndex = 1;
            this.UxAddBtn.Text = "+";
            this.UxAddBtn.UseVisualStyleBackColor = true;
            this.UxAddBtn.Click += new System.EventHandler(this.UxAddBtn_Click);
            // 
            // UxAlarmList
            // 
            this.UxAlarmList.DisplayMember = "(none)";
            this.UxAlarmList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxAlarmList.FormattingEnabled = true;
            this.UxAlarmList.ItemHeight = 25;
            this.UxAlarmList.Location = new System.Drawing.Point(24, 106);
            this.UxAlarmList.Margin = new System.Windows.Forms.Padding(2);
            this.UxAlarmList.Name = "UxAlarmList";
            this.UxAlarmList.ScrollAlwaysVisible = true;
            this.UxAlarmList.Size = new System.Drawing.Size(543, 104);
            this.UxAlarmList.TabIndex = 2;
            this.UxAlarmList.SelectedIndexChanged += new System.EventHandler(this.UxAlarmList_SelectedIndexChanged);
            this.UxAlarmList.SelectedValueChanged += new System.EventHandler(this.UxAlarmList_SelectedIndexChanged);
            // 
            // UxActiveAlarms
            // 
            this.UxActiveAlarms.DisplayMember = "(none)";
            this.UxActiveAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxActiveAlarms.FormattingEnabled = true;
            this.UxActiveAlarms.ItemHeight = 25;
            this.UxActiveAlarms.Location = new System.Drawing.Point(24, 244);
            this.UxActiveAlarms.Margin = new System.Windows.Forms.Padding(2);
            this.UxActiveAlarms.Name = "UxActiveAlarms";
            this.UxActiveAlarms.ScrollAlwaysVisible = true;
            this.UxActiveAlarms.Size = new System.Drawing.Size(543, 104);
            this.UxActiveAlarms.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "All Alarms:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Active Alarms:";
            // 
            // Alarm501
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UxActiveAlarms);
            this.Controls.Add(this.UxAlarmList);
            this.Controls.Add(this.UxAddBtn);
            this.Controls.Add(this.UxEditBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Alarm501";
            this.Text = "Alarm501";
            ((System.ComponentModel.ISupportInitialize)(this.alarm501BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UxEditBtn;
        private System.Windows.Forms.Button UxAddBtn;
        private System.Windows.Forms.ListBox UxAlarmList;
        private System.Windows.Forms.BindingSource alarm501BindingSource;
        private System.Windows.Forms.ListBox UxActiveAlarms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

