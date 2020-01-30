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
    public partial class AddAlarmForm : Form
    {
        public DateTime Time;
        public bool Status;
        public AddAlarmForm()
        {
            InitializeComponent();
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            Time = dateTimePicker1.Value;
            Status = OnButton.Checked;
            this.DialogResult = DialogResult.OK;
        }
    }
}
