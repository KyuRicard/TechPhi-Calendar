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
        public Arkanoid()
        {
            InitializeComponent();
        }

        private void Arkanoid_Load(object sender, EventArgs e)
        {

        }

        private void Arkanoid_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.A:
                    if (Plataforma.Location.X > 0)
                        Plataforma.Location = new Point(Plataforma.Location.X - 10, 610);
                    break;
                case Keys.D:
                    if (Plataforma.Location.X + Plataforma.Width < Width)
                        Plataforma.Location = new Point(Plataforma.Location.X + 10, 610);
                    break;
                case Keys.Space:
                    if (!isPressed)
                    {
                        timePressed = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                        isPressed = true;
                    }                      
                    break;
            }
        }

        private void Arkanoid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
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
    }
}
