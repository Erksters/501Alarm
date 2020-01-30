using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        //Hold all alarm events
        public List<AlarmClass> ListOfAlarms = new List<AlarmClass>();
        
        //The Add button
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Open the AddAlarmForm
            AddAlarmForm AddingAlarmForm = new AddAlarmForm();
            if (AddingAlarmForm.ShowDialog() == DialogResult.OK) 
                {
                //If we need to add a alarm, then add one
                AlarmClass newAlarm = new AlarmClass(AddingAlarmForm.Time.Hour, AddingAlarmForm.Time.Minute, AddingAlarmForm.Status);
                ListOfAlarms.Add(newAlarm);
                EditButton.Enabled = true;
                updateAlarmList();
                }
        }

        //This method will check each alarms in the list,
        //Check if we have a total of 10 alarms, 
        //and set a new timer if needed.
        private void updateAlarmList()
        {
            if(ListOfAlarms.Count > 10)
            {
                ListOfAlarms.RemoveAt(10);
            }
            else
            {   
                //Remove copies
                //ListOfAlarms.Sort();

                //Add Alarms to Visible list
                AllAlarms.Items.Clear();
                foreach(AlarmClass item in ListOfAlarms)
                {
                    AllAlarms.Items.Add(item.ToString());
                }
            }
        }
    }
}
