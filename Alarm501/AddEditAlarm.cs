using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alarm501ModelController;
using static Alarm501ModelController.AlarmModel;


namespace Alarm501
{
    public partial class AddEditAlarm : Form
    {

        // Name of the alarm
        public string AlarmName { get; set; } = "Alarm Name (optional)";

        // Date and time of the alarm
        public DateTime DateTime { get; set; } = DateTime.Now;

        // Whether the alarm is on or off
        public bool IsOn { get; set; } = false;

        // Sound of the alarm
        public AlarmSounds AlarmSound { get; set; } = AlarmSounds.Radar;

        // Whether the alarm is repeating
        public bool IsRepeating { get; set; } = false;

        // Days the alarm is repeating on
        public List<bool> RepeatingDays { get; set; } = new List<bool> { false, false, false, false, false, false, false };

        // Index of the alarm in the list
        public int Index { get; set; } = -1;

        private AlarmHandler AlarmHandler;
        private CreateAlarm createAlarm;
        private AlarmModel alarmModel;

        // Constructor for adding a new alarm
        public AddEditAlarm(CreateAlarm ca)
        {
            createAlarm = ca;

            InitializeComponent();

            UxAlarmSoundSet.DataSource = Enum.GetValues(typeof(AlarmSounds));
        }

        public AddEditAlarm(CreateAlarm ca, int selectedIndex)
        {
            createAlarm = ca;
            Alarm alarm = AlarmModel.alarmList[selectedIndex];

            AlarmName = alarm.AlarmName;
            DateTime = alarm.AlarmTime;
            IsOn = alarm.IsOn;
            AlarmSound = alarm.AlarmSound;
            IsRepeating = alarm.IsRepeating;
            RepeatingDays = alarm.RepeatingDays;
            Index = alarm.Index;

            InitializeComponent();

            UxAlarmSoundSet.DataSource = Enum.GetValues(typeof(AlarmSounds));

            UxAlarmSoundSet.SelectedItem = AlarmSound;

            for (int i = 0; i < UxRepeatingScheduleDays.Items.Count; i++)
            {
                UxRepeatingScheduleDays.SetItemChecked(i, RepeatingDays[i]);
            }

            UxAlarmName.Text = AlarmName;
            dateTimePicker1.Value = DateTime;
            checkBox1.Checked = IsOn;
            //UxAlarmSound.SelectedIndex = (int)alarmSound;
            UxRepeatingSchedulesCheck.Checked = IsRepeating;
        }

        // Set the alarm, if Index == -1, add a new alarm, otherwise edit the alarm
        private void UXSetAlarmBtn_Click(object sender, EventArgs e)
        {
            List<bool> temp = new List<bool>();

            for (int i = 0; i < UxRepeatingScheduleDays.Items.Count; i++)
            {
                temp.Add(UxRepeatingScheduleDays.GetItemChecked(i));
            }

            createAlarm(UxAlarmName.Text, dateTimePicker1.Value, checkBox1.Checked, (AlarmSounds)UxAlarmSoundSet.SelectedItem, UxRepeatingSchedulesCheck.Checked, temp, Index);
            this.Close();
        }

        // Close the form on cancel
        private void UxCancelEditAlarmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Update the repeating schedule check
        private void UxRepeatingSchedulesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(UxRepeatingSchedulesCheck.Checked)
            {
                UxRepeatingScheduleDays.Enabled = true;
            }
            else
            {
                UxRepeatingScheduleDays.Enabled = false;
            }
        }

        // Update the repeating days list
        private void UxRepeatingScheduleDays_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < UxRepeatingScheduleDays.Items.Count; i++)
            {
                RepeatingDays[i] = UxRepeatingScheduleDays.GetSelected(i);
            }
        }
    }
}
