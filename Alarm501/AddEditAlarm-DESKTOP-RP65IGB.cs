using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class AddEditAlarm : Form
    {
        public DateTime DateTime { get; set; } = DateTime.Now;

        public bool IsOn { get; set; } = false;

        public int Index { get; set; } = -1;

        public AddEditAlarm()
        {
            InitializeComponent();
        }

        public AddEditAlarm(DateTime dateTime, bool isOn, int index)
        {
            DateTime = dateTime;
            IsOn = isOn;
            Index = index;

            InitializeComponent();

            dateTimePicker1.Value = DateTime;
            checkBox1.Checked = IsOn;
        }

        private void UXSetAlarmBtn_Click(object sender, EventArgs e)
        {
            // add the alarm somehow
            if(Index != -1)
            {
                Alarm501.EditAlarm(new Alarm(dateTimePicker1.Value, checkBox1.Checked), Index);
            }
            else
            {
                Alarm501.AddAlarm(new Alarm(dateTimePicker1.Value, checkBox1.Checked));
            }
            this.Close();
        }

        private void UxCancelEditAlarmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
