using PhidgetInteraction;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calendari
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            Parser.SensorRead();
            timer1.Start();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Sensor> sensors = Input.GetSensors();
            for (int i = 1; i <= 3; i++)
            {
                Sensor s = sensors[i - 1];
                switch(i)
                {
                    case 1:
                        label1.Text = s.RawValue.ToString();
                        checkBox1.Checked = s.Activated;
                        break;
                    case 2:
                        label2.Text = s.RawValue.ToString();
                        checkBox2.Checked = s.Activated;
                        break;
                    case 3:
                        label3.Text = s.RawValue.ToString();
                        checkBox3.Checked = s.Activated;
                        break;
                }
            }
        }
    }
}
