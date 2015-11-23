using System;
using PhidgetInteraction;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Calendari
{
    public partial class Calendari : Form
    {
        DateTime mc;
        long timePressed = 0;
        bool isPressed = false;
        InterPhi phi;       

        public Calendari()
        {
            InitializeComponent();
            mc = DateTime.Now;
            GetSetmanaActual();

            phi = new InterPhi();

            phi.AddSensor(new Sensor("0", "A", 850));
            phi.AddSensor(new Sensor("1", "D", 850));
            phi.AddSensor(new Sensor("2", "SPACE", 500));

            phi.StartPhidget();
            timer2.Start();
        }

        private void Calendari_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.A:
                    MoveDays(-7);
                    break;
                case Keys.D:
                    MoveDays(7);
                    break;
                case Keys.Space:
                    SpaceControl(true);   
                    break;
            }
        }

        private void MoveDays(int days)
        {
            mc = mc.AddDays(days);
            GetSetmanaActual();
        }

        private void SpaceControl(bool isDown)
        {
            if (isDown)
            {
                if (!isPressed)
                {
                    timePressed = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                    isPressed = true;
                }
            }
            else
            {
                long timeNow = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                if (timeNow - timePressed > 2000)
                {
                    mc = DateTime.Now;
                    GetSetmanaActual();
                }
                else
                {
                    new Arkanoid().Show();
                }
                isPressed = false;
            }
        }
        private void GetSetmanaActual()
        {            
            DateTime monday = mc.AddDays(-((int)mc.DayOfWeek - 1));
            DateTime sunday = monday.AddDays(6);
            SetText(string.Format("Setmana del {0} de {1} de {2} al {3} de {4} de {5}",
                monday.Day, GetMonth(monday.Month), monday.Year, sunday.Day, GetMonth(sunday.Month), sunday.Year), Setmana);
        }

        private void SetText(string text, TextBox tb)
        {                       
            tb.Text = text;
        }


        private string GetMonth(int month)
        {
            switch (month)
            {
                case 1:
                    return "gener";
                case 2:
                    return "febrer";
                case 3:
                    return "març";
                case 4:
                    return "abril";
                case 5:
                    return "maig";
                case 6:
                    return "juny";
                case 7:
                    return "juliol";
                case 8:
                    return "agost";
                case 9:
                    return "septembre";
                case 10:
                    return "octubre";
                case 11:
                    return "novembre";
                case 12:
                    return "desembre";
                default:
                    return "undefined";

            }
        }

        private void Calendari_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                SpaceControl(false);
            }
        }

        private void CheckPhidgets()
        {
            List<Sensor> sensors = phi.GetKeys();

            foreach (Sensor s in sensors)
            {
                Console.WriteLine("Sensor {0} Value {1}", s.Value, s.Activated);
            }
            
            if (phi.GetValue("A"))
            {
                MoveDays(-7);
            }
            else if (phi.GetValue("D"))
            {
                MoveDays(7);
            }
            /*else if (phi.GetValue("SPACE"))
            {
                SpaceControl(true);
            }
            else if (!phi.GetValue("SPACE") && isPressed)
            {
                SpaceControl(false);
            }*/
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            CheckPhidgets();
        }
    }
}
