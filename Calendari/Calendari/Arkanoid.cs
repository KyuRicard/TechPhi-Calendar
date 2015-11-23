using PhidgetInteraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendari
{
    public partial class Arkanoid : Form
    {
        long timePressed = 0;
        bool isPressed = false;
        private InterPhi phi;
        public Arkanoid()
        {
            InitializeComponent();
        }

        private void Arkanoid_Load(object sender, EventArgs e)
        {
            phi = new InterPhi();

            phi.AddSensor(new Sensor("0", "A", 850));
            phi.AddSensor(new Sensor("1", "D", 850));
            phi.AddSensor(new Sensor("2", "SPACE", 500));

            phi.StartPhidget();
            timer1.Start();
        }

        private void Arkanoid_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.A:
                    MoveLeft();
                    break;
                case Keys.D:
                    MoveRight();
                    break;
                case Keys.Space:
                    PressSpace(true);
                    break;
            }
        }

        private void MoveLeft()
        {
            if (Plataforma.Location.X > 0)
            {
                Plataforma.Location = new Point(Plataforma.Location.X - 10, 610);
            }
               
        }

        private void PressSpace(bool down)
        {
            if (down)
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
                    Close();
                }
                else
                {

                }
            }
        }

        private void MoveRight()
        {
            if (Plataforma.Location.X + Plataforma.Width < Width)
            {
                Plataforma.Location = new Point(Plataforma.Location.X + 10, 610);
            }
        }

        private void Arkanoid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                PressSpace(false);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Sensor> sensors = phi.GetKeys();

            foreach (Sensor s in sensors)
            {
                Console.WriteLine("Sensor {0} Value {1}", s.Value, s.Activated);
            }

            if (phi.GetValue("A"))
            {
                MoveLeft();
            }
            else if (phi.GetValue("D"))
            {
                MoveRight();
            }
            /*else if (phi.GetValue("SPACE"))
            {
                PressSpace(true);
            }
            else if (!phi.GetValue("SPACE") && isPressed)
            {
                PressSpace(false);
            }*/
        }
    }
}
