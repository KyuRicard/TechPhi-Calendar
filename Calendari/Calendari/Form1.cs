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
    public partial class Calendari : Form
    {
        DateTime mc;
        long timePressed = 0;
        bool isPressed = false;

        public Calendari()
        {
            InitializeComponent();
            mc = DateTime.Now;
            GetSetmanaActual();
        }

        private void Calendari_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.A:
                    mc = mc.AddDays(-7);
                    GetSetmanaActual();
                    break;
                case Keys.D:
                    mc = mc.AddDays(7);
                    GetSetmanaActual();
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

        private void GetSetmanaActual()
        {
            DateTime monday = mc.AddDays(((int)mc.DayOfWeek - 1));
            DateTime sunday = monday.AddDays(6);
            Setmana.Text = string.Format("Setmana del {0} de {1} de {2} al {3} de {4} de {5}",
                monday.Day, GetMonth(monday.Month), monday.Year, sunday.Day, GetMonth(sunday.Month), sunday.Year);
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

        private void Calendari_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
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

    }
}
