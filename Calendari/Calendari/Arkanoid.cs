using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calendari
{
    public partial class Arkanoid : Form
    {
        long timePressed = 0;
        bool isPressed = false;
        public Arkanoid()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Arkanoid_Load(object sender, EventArgs e)
        {
            
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
                    //Calendari.StartTimer();
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

            if (Input.GetInput("A"))
            {
                MoveLeft();
            }
            else if (Input.GetInput("D"))
            {
                MoveRight();
            }
            else if (Input.GetInput("SPACE"))
            {
                PressSpace(true);
            }
            else if (!Input.GetInput("SPACE") && isPressed)
            {
                PressSpace(false);
            }
        }

    }
}
