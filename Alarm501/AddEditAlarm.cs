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

        // Constructor for adding a new alarm
        public AddEditAlarm(AlarmHandler alarmHandler)
        {
            AlarmHandler = alarmHandler;

            InitializeComponent();

            UxAlarmSoundSet.DataSource = Enum.GetValues(typeof(AlarmSounds));
        }

        // Constructor for editing an alarm
        public AddEditAlarm(DateTime dateTime, bool isOn, AlarmSounds alarmSound, bool isRepeating, List<bool> repeatingDays, string alarmName, int index, AlarmHandler alarmHandler)
        {
            AlarmName = alarmName;
            DateTime = dateTime;
            IsOn = isOn;
            AlarmSound = alarmSound;
            IsRepeating = isRepeating;
            RepeatingDays = repeatingDays;
            Index = index;
            AlarmHandler = alarmHandler;

            InitializeComponent();

            UxAlarmSoundSet.DataSource = Enum.GetValues(typeof(AlarmSounds));

            UxAlarmSoundSet.SelectedItem = AlarmSound;

            for (int i = 0; i < UxRepeatingScheduleDays.Items.Count; i++)
            {
                UxRepeatingScheduleDays.SetItemChecked(i, RepeatingDays[i]);
            }

            UxAlarmName.Text = AlarmName;
            dateTimePicker1.Value = dateTime;
            checkBox1.Checked = isOn;
            //UxAlarmSound.SelectedIndex = (int)alarmSound;
            UxRepeatingSchedulesCheck.Checked = isRepeating;
            //implement repeating days
        }

        // Set the alarm, if Index == -1, add a new alarm, otherwise edit the alarm
        private void UXSetAlarmBtn_Click(object sender, EventArgs e)
        {
            List<bool> temp = new List<bool>();

            for (int i = 0; i < UxRepeatingScheduleDays.Items.Count; i++)
            {
                temp.Add(UxRepeatingScheduleDays.GetItemChecked(i));
            }

            AlarmHandler.Invoke(Index, new AlarmModel.Alarm(UxAlarmName.Text, dateTimePicker1.Value, checkBox1.Checked, (AlarmSounds)UxAlarmSoundSet.SelectedItem, UxRepeatingSchedulesCheck.Checked, Index, temp));
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
