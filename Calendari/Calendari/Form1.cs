using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calendari
{
    public partial class Calendari : Form
    {
        DateTime mc;
        DateTime hora;
        DateTime monday, sunday;
        long timePressed = 0;
        bool isPressed = false;
        bool A = false, D = false;
        bool Arkanoid = false;
        bool Blink = false;
        public static int ScreenHeight;
        private Random rand;

        public Calendari()
        {
            InitializeComponent();
            InitLabels();
            mc = DateTime.Now;
            hora = DateTime.Now;

            rand = new Random();

            GetSetmanaActual();

            Parser.SensorRead();
            timer2.Start();
            timer1.Start();
            UpdateTick.Start();
            timer1_Tick(this, null);

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
            Size = Screen.PrimaryScreen.WorkingArea.Size;

            Height = 900;
            ScreenHeight = Height;
            panel1.Width = Width;
            panel1.Height = Height - 5;

            panel2.Width = Width;
            panel2.Height = Height;

            Hora.Width = panel1.Width;

            tableLayoutPanel1.Width = panel1.Width - 5;
            tableLayoutPanel1.Height = panel1.Height - Setmana.Height - Hora.Height;

            Setmana.Width = panel1.Width;
            SetColors(0, 128, 255);
            Platform.Location = new Point(Width - Platform.Width, Height - Platform.Height);

            ArkanoidControl.InitBall(TheBall);
            TheBall.Image = new Bitmap(Image.FromFile("img/bola.png"), 64, 64);

            Parser.ReadScore();
        }

        private void SetColors(int red, int green, int blue)
        {
            tableLayoutPanel1.BackColor = Color.FromArgb(red, green, blue);
            Dilluns.BackColor = Color.FromArgb(red, green, blue);
            Dimarts.BackColor = Color.FromArgb(red, green, blue);
            Dimecres.BackColor = Color.FromArgb(red, green, blue);
            Dijous.BackColor = Color.FromArgb(red, green, blue);
            Divendres.BackColor = Color.FromArgb(red, green, blue);
            Dissabte.BackColor = Color.FromArgb(red, green, blue);
        }
        
        private void SetHora()
        {
            hora = DateTime.Now;
            if (!Blink) 
                Hora.Text = hora.Hour + ":" + hora.Minute.ToString("00");
            else
                Hora.Text = hora.Hour + " " + hora.Minute.ToString("00");
            Blink = !Blink;
        }

        private void Calendari_KeyDown(object sender, KeyEventArgs e)
        {
            if (Input.GetState())
                return;
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
                case Keys.Escape:
                    Application.Exit();
                    break;
            }
        }

        private void MovePlatform(int v)
        {
            if (Platform.Location.X <= 0 && v < 0 || Platform.Location.X >= panel2.Width - Platform.Width && v > 0)
            {
                return;
            }
            else
            {
                Platform.Location = new Point(Platform.Location.X + (Platform.Width / 2) * v, Platform.Location.Y);
                if (Platform.Location.X < 0)
                {
                    Platform.Location = new Point(0, Platform.Location.Y);
                }
                if (Platform.Location.X > panel2.Width - Platform.Width)
                {
                    Platform.Location = new Point(panel2.Width - Platform.Width, Platform.Location.Y);
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
                            label2.BackColor = tableLayoutPanel1.BackColor;
                            label2.Location = new Point(Width / 2 - label2.Width / 2, Height / 2 - label2.Height / 2);
                            label2.Visible = true;
                        }
                        else
                        {                            
                            label2.Text = "Obrint Calendari\nTreu la mà";
                            label2.BackColor = panel2.BackColor;
                            label2.Location = new Point(Width / 2 - label2.Width / 2, Height / 2 - label2.Height / 2);
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
                        int seed = (rand.Next(10) + 1);
                        panel2.BackgroundImage = new Bitmap(Image.FromFile("img/" + seed + ".jpg"), Width, Height);
                        ArkanoidControl.seed = seed;
                    }
                    isPressed = false;
                }
                else if (Arkanoid)
                {
                    long timeNow = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                    if (timeNow - timePressed < 2000)
                    {
                        label2.Visible = false;
                        ArkanoidControl.Score = 0;
                        GeneratePlatforms(ArkanoidControl.seed);
                        ArkanoidControl.ThrowBall();
                    }
                    else
                    {
                        panel1.Visible = true;
                        panel2.Visible = false;
                        Arkanoid = false;
                        label2.Visible = false;
                        ArkanoidControl.Close();
                        panel2.Controls.Clear();
                        panel2.Controls.Add(TheBall);
                        panel2.Controls.Add(Platform);
                    }
                    isPressed = false;
                }
            }
        }

        private void GetSetmanaActual()
        {            
            monday = mc.AddDays(-((int)mc.DayOfWeek - 1));
            sunday = monday.AddDays(6);
            if (monday.Month == sunday.Month)
            {
                SetText(GetMonth(monday.Month).ToUpper() + " " + monday.Year, Setmana);
            }
            else
            {
                SetText(string.Format("{0} - {1}", GetMonth(monday.Month).ToUpper() + " " + monday.Year, GetMonth(sunday.Month).ToUpper() + " " + sunday.Year), Setmana);
            }
            Dilluns.Text = "DILLUNS \n" + monday.Day;
            Dimarts.Text = "DIMARTS \n" + monday.AddDays(1).Day;
            Dimecres.Text = "DIMECRES \n" + monday.AddDays(2).Day;
            Dijous.Text = "DIJOUS \n" + monday.AddDays(3).Day;
            Divendres.Text = "DIVENDRES \n" + monday.AddDays(4).Day;
            Dissabte.Text = "DISSABTE \n" + monday.AddDays(5).Day;

            foreach(Label lbl in Dies)
            {
                lbl.Text = "";
            }

            List<Clase> classes = Parser.GetClases();
            ManageClases(classes);
        }

        private void SetText(string text, Label tb)
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

        private void Calendari_KeyUp(object sender, KeyEventArgs e)
        {
            if (Input.GetState())
                return;
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
                LeftControl(true);
            }
            else if (Input.GetInput("D") && !D)
            {                
                D = true;
                RightControl(true);
            }
            else if (!Input.GetInput("A") && A)
            {
                A = false;
                LeftControl(false);
            }
            else if (!Input.GetInput("D") && D)
            {
                D = false;                
                RightControl(false);
            }
            else if (Input.GetInput("SPACE"))
            {
                SpaceControl(true);
            }
            else if (!Input.GetInput("SPACE") && isPressed)
            {
                SpaceControl(false);
            }
        }

        private void LeftControl(bool v)
        {
            if (v && Arkanoid)
            {
                MovePlatform(-1);
            }
            else if (!Arkanoid && !v)
            {
                MoveDays(-7);
            }
        }

        private void RightControl(bool enabled)
        {
            if (enabled && Arkanoid)
            {
                MovePlatform(1);
            }
            else if (!Arkanoid && !enabled)
            {
                MoveDays(7);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Input.GetState())
                CheckPhidgets();
            SetHora();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Parser.ReadXML("test.xml");
            List<Clase> classes = Parser.GetClases();
            ManageClases(classes);
        }

        private void ManageClases(List<Clase> classes)
        {
            foreach (Clase c in classes)
            {
                DateTime dt = new DateTime(c.Date.Year, c.Date.Month, c.Date.Day);
                if (dt.DayOfWeek != DayOfWeek.Sunday)
                {
                    int day = (int)dt.DayOfWeek - 1;
                    int inici = Toolz.GetTimeFragment(c.Start);
                    int final = Toolz.GetTimeFragment(c.Finish);

                    for (int i = inici; i <= final; i++)
                    {
                        Dies[day, i].Text = c.Name + "\n" + c.Professor;
                    }
                }
            }
        }

        private void UpdateTick_Tick(object sender, EventArgs e)
        {
            if (Arkanoid)
            {
                int playing = ArkanoidControl.MoveBall(Width, Height, TheBall, Platform);
                if (playing == 0)
                {
                    label2.Text = "GAME OVER!\nScore: " + ArkanoidControl.Score;
                    label2.BackColor = panel2.BackColor;
                    label2.Location = new Point(Width / 2 - label2.Width / 2, Height / 2 - label2.Height / 2);
                    label2.Visible = true;
                }
                else if (playing == 2)
                {
                    ArkanoidControl.b.X = Platform.Location.X + (Platform.Size.Width / 2) - (ArkanoidControl.b.Width / 2);
                    ArkanoidControl.b.Y = Platform.Location.Y - Platform.Size.Height - 30;
                    GeneratePlatforms(ArkanoidControl.seed);
                    ArkanoidControl.ThrowBall();
                }
            }
        }

        private void InitLabels()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Label lbl = new Label();
                    lbl.AutoSize = true;
                    lbl.Anchor = AnchorStyles.None;
                    lbl.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    lbl.ForeColor = Color.White;
                    lbl.Location = new Point(537, 192);
                    lbl.Name = "Label_" + i + ":" + j;
                    lbl.Size = new Size(170, 63);
                    lbl.TabIndex = 7;
                    lbl.Text = lbl.Name;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Visible = true;
                    tableLayoutPanel1.Controls.Add(lbl, i + 1, j + 1);
                    Dies[i, j] = lbl;
                }
            }
        }

        private int GetDay(Date date)
        {
            int curr = date.Day;
            return curr - monday.Day;
        }

        public void GeneratePlatforms(int seed)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(TheBall);
            panel2.Controls.Add(Platform);
            Random rand = new Random();
            Color[] colors = Planet.GetColor(seed);
            ArkanoidControl.Platforms.Clear();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button lbl = new Button();
                    lbl.AutoSize = false;
                    lbl.Size = new Size(150, 30);
                    lbl.Enabled = false;
                    lbl.Location = new Point(j * Width/10, i * Height/15);
                    int val = rand.Next(2);
                    lbl.BackColor = colors[val];
                    ArkanoidControl.Platforms.Add(lbl);
                    panel2.Controls.Add(lbl);
                }
            }
        }
    }
}
