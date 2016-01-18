using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calendari
{
    public partial class Calibration : Form
    {
        public Calibration()
        {
            InitializeComponent();
            Input.StartInput();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<int, List<float>> valors = new Dictionary<int, List<float>>();
            for (int i = 0; i < 3; i++)
            {
                List<float> value = new List<float>();
                MessageBox.Show("Calibration", string.Format("Sensor {0}: No posar la ma", i), MessageBoxButtons.OK);
                value.Add(Calibrate(i));

                MessageBox.Show("Calibration", string.Format("Sensor {0}: Posa la ma", i), MessageBoxButtons.OK);
                value.Add(Calibrate(i));

                valors.Add(i, value);
            }

            textBox1.Text = valors[0][0].ToString();
            textBox2.Text = valors[1][0].ToString();
            textBox3.Text = valors[2][0].ToString();
            textBox4.Text = valors[0][1].ToString();
            textBox5.Text = valors[1][1].ToString();
            textBox6.Text = valors[2][1].ToString();
        }

        private float Calibrate(int sensor)
        {
            List<int> values = new List<int>(10000);
            for (int i = 0; i < 10000; i++)
            {
                values.Add(Input.GetRawValue(sensor));
            }
            float sum = 0;
            foreach(int i in values)
            {
                sum += i;
            }
            sum /= 10000;
            return sum;
        }
    }
}
