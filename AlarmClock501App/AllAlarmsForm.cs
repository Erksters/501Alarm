using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock501App
{
    public partial class AllAlarmsForm : Form
    {
        public AllAlarmsForm()
        {
            InitializeComponent();
        }

        private Thread checkThread;

        private Thread ringingThread;

        private Thread SnoozeThread;


        //Hold all alarm events
        public List<AlarmClass> ListOfAlarms = new List<AlarmClass>();
        bool ringing = false;


        private void AddAlarm()
        {
            SnoozeButton.Enabled = true;
            StopButton.Enabled = true;
            //Open the AddAlarmForm
            AddAlarmForm AddingAlarmForm = new AddAlarmForm();
            DialogResult result = AddingAlarmForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //If we need to add a alarm, then add one
                AlarmClass newAlarm = new AlarmClass(AddingAlarmForm.Time.Hour, AddingAlarmForm.Time.Minute, AddingAlarmForm.Status, AddingAlarmForm.Time.Second, AddingAlarmForm.Time);
                ListOfAlarms.Add(newAlarm);
                EditButton.Enabled = true;
                updateAlarmList();
                SnoozeButton.Enabled = true;
                StopButton.Enabled = true;
            }
        }

      
        //This method will check each alarms in the list,
        //Check if we have a total of 10 alarms, 
        //and set a new timer if needed.
        private void updateAlarmList()
        {
            //Check length limit
            if (ListOfAlarms.Count > 10)
            {
                ListOfAlarms.RemoveAt(10);
                MessageBox.Show("Length limit reached");
            }
            else
            {

                //Add Alarms to Visible list
                AllAlarms.Items.Clear();
                foreach (AlarmClass item in ListOfAlarms)
                {
                    AllAlarms.Items.Add(item.ToString());
                    runChecker();
                }
            }
        }
        
        public async void runChecker()
        {
            checkThread = new Thread(new ThreadStart(CheckAlarms));
            checkThread.Start();

        }

        private void CheckAlarms()
        {
            DateTime today = DateTime.Today;
            DateTime Then = new DateTime(today.Year, today.Month, today.Day, today.Hour+1, today.Minute, today.Second);
            try
            {
                while (DateTime.Now.Hour != Then.Hour)
                {
                    foreach (AlarmClass Alarm in ListOfAlarms)
                    {
                        if (Alarm.status && (Alarm.Time.Year.Equals(DateTime.Now.Year) && (Alarm.Time.Day.Equals(DateTime.Now.Day) && (Alarm.Time.Minute.Equals(DateTime.Now.Minute) && (Alarm.Time.Second.Equals(DateTime.Now.Second))))))
                        {
                            ringing = true;
                            break;
                        }
                    }
                    if (ringing)
                    {
                        break;
                    }
                }
                ringingThread = new Thread(new ThreadStart(CheckStop));
                ringingThread.Start();
                
            }
            catch(Exception e)
            {
                checkThread = new Thread(new ThreadStart(CheckAlarms));
                checkThread.Start();
            }
        }

        private void CheckStop()
        {
            int i = 0;
            while (true)
            {
                //label1.Text = String.Format("{0} Seconds since Alarm began",i);
                this.Invoke(new Action(() => { MessageBox.Show(this, "RINGING"); }));                
                Thread.Sleep(4000);
                if (!ringing)
                {
                    break;
                }
                i++;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
         AddAlarm();
        }
        
        private void EditButton_Click(object sender, EventArgs e)
        {
            if(AllAlarms.Items.Count > 0)
            {                
                AddAlarmForm AddingAlarmForm = new AddAlarmForm(ListOfAlarms.ElementAt(AllAlarms.SelectedIndex).Time);
                if (AddingAlarmForm.ShowDialog() == DialogResult.OK)
                {
                    DeleteAlarm(ListOfAlarms.ElementAt(AllAlarms.SelectedIndex));
                    //If we need to add a alarm, then add one
                    AlarmClass newAlarm = new AlarmClass(AddingAlarmForm.Time.Hour, AddingAlarmForm.Time.Minute, AddingAlarmForm.Status, AddingAlarmForm.Time.Second, AddingAlarmForm.Time);
                    ListOfAlarms.Add(newAlarm);
                    EditButton.Enabled = true;
                    updateAlarmList();
                }
            }
            

        }


        private void DeleteAlarm(AlarmClass Alarm)
        {
            ListOfAlarms.Remove(Alarm);
            updateAlarmList();

        }

        private void AllAlarms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (ringing)
            {
                MessageBox.Show("Alarm Stopped");
                SnoozeButton.Enabled = false;
            }
            ringing = false;
            StopButton.Enabled = false;
        }

        private void SnoozeButton_Click(object sender, EventArgs e)
        {
            ringing = false;
            SnoozeThread = new Thread(new ThreadStart(RingIn30));
            SnoozeThread.Start();
            SnoozeButton.Enabled = false;
        }

        //The snooze button will call this method. Program will sleep on it. 
        public void RingIn30()
        {
            MessageBox.Show("Snoozed for 30 seconds");
            Thread.Sleep(30000);
            ringing = true;
            runChecker(); 
        }
    }
}
