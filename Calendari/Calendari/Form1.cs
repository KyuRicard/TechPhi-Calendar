using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calendari
{
    public partial class Calendari : Form
    {
        DateTime mc;
        long timePressed = 0;
        bool isPressed = false;
        bool A = false, D = false;
        bool Arkanoid = false;

        public Calendari()
        {
            InitializeComponent();
            mc = DateTime.Now;
            GetSetmanaActual();
            Input.StartInput();
            timer2.Start();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            panel1.Width = Width;
            panel1.Height = Height;

            panel2.Width = Width;
            panel2.Height = Height;

            tableLayoutPanel1.Width = panel1.Width;
            tableLayoutPanel1.Height = panel1.Height;

            label1.Location = new Point(0, Height - label1.Height);
        }

        private void Calendari_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.A:
                    if (!Arkanoid)
                        MoveDays(-7);
                    else
                        MovePlatform(-1);
                    break;
                case Keys.D:
                    if (!Arkanoid)
                        MoveDays(7);
                    else
                        MovePlatform(1);
                    break;
                case Keys.Space:
                    SpaceControl(true);   
                    break;
            }
        }

        private void MovePlatform(int v)
        {
            if (label1.Location.X <= 0 && v < 0 || label1.Location.X >= panel2.Width - label1.Width && v > 0)
            {
                return;
            }
            else
            {
                label1.Location = new System.Drawing.Point(label1.Location.X + (label1.Width / 2) * v, label1.Location.Y);
                if (label1.Location.X < 0)
                {
                    label1.Location = new System.Drawing.Point(0, label1.Location.Y);
                }
                if (label1.Location.X > panel2.Width - label1.Width)
                {
                    label1.Location = new System.Drawing.Point(panel2.Width - label1.Width, label1.Location.Y);
                }
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
                else
                {
                    long timeNow = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                    if (timeNow - timePressed > 2000)
                    {
                        if (!Arkanoid)
                        {
                            label2.Text = "Obrint Arkanoid\nTreu la mà";
                            label2.BackColor = panel1.BackColor;
                            label2.Location = new System.Drawing.Point(Width / 2 - label2.Width / 2, Height / 2 - label2.Height / 2);
                            label2.Visible = true;
                        }
                        else
                        {                            
                            label2.Text = "Obrint Calendari\nTreu la mà";
                            label2.BackColor = panel2.BackColor;
                            label2.Location = new System.Drawing.Point(Width / 2 - label2.Width / 2, Height / 2 - label2.Height / 2);
                            label2.Visible = true;
                        }
                    }
                }
            }
            else
            {
                if (!Arkanoid)
                {
                    long timeNow = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                    if (timeNow - timePressed < 2000)
                    {
                        mc = DateTime.Now;
                        GetSetmanaActual();
                    }
                    else
                    {
                        panel1.Visible = false;
                        panel2.Visible = true;
                        Arkanoid = true;
                        label2.Visible = false;
                    }
                    isPressed = false;
                }
                else if (Arkanoid)
                {
                    long timeNow = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                    if (timeNow - timePressed < 2000)
                    {
                        mc = DateTime.Now;
                        GetSetmanaActual();
                    }
                    else
                    {
                        panel1.Visible = true;
                        panel2.Visible = false;
                        Arkanoid = false;
                        label2.Visible = false;
                    }
                    isPressed = false;
                }
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
            if (Input.GetInput("A") && !A)
            {                
                A = true;
            }
            else if (Input.GetInput("D") && !D)
            {                
                D = true;
            }
            else if (!Input.GetInput("A") && A)
            {
                A = false;
                MoveDays(-7);
            }
            else if (!Input.GetInput("D") && D)
            {
                D = false;
                MoveDays(7);
            }
            else if (Input.GetInput("SPACE"))
            {
                SpaceControl(true);
            }
            else if (!Input.GetInput("SPACE") && isPressed)
            {
                //SpaceControl(false);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            CheckPhidgets();
        }
    }
}
