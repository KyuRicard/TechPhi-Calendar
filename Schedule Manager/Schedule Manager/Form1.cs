using Calendari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Parser.ReadXML("test.xml");
            fill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            dt.AddDays(-((int)dt.DayOfWeek - 1));
            Clase c = new Clase
            {
                Name = Assignatura.Text,
                Professor = Professor.Text,
                Date = new Date
                {
                    Day = dt.Day,
                    Month = dt.Month,
                    Year = dt.Year
                },
                Start = Toolz.GetHour((int)Torn.Value, TimeSet.START),
                Finish = Toolz.GetHour((int)Torn.Value + (int)NumberOfTurns.Value - 1, TimeSet.FINISH)
            };
            Parser.AddClase(c);
            fill();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex > Parser.GetClases().Count - 1)
                return;
            Clase c = Parser.GetClases()[listBox1.SelectedIndex];
            Asg.Text = c.Name;
            Prof.Text = c.Professor;
            Day.Text = string.Format("{0} de {1} de {2}", c.Date.Day, c.Date.Month, c.Date.Year);
            Hour.Text = string.Format("{0}:{1} - {2}:{3}",
                c.Start.Hour, c.Start.Minute, c.Finish.Hour, c.Finish.Minute);
        }

        private void fill()
        {
            listBox1.Items.Clear();
            foreach(Clase c in Parser.GetClases())
            {
                listBox1.Items.Add(c.Name);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parser.WriteXML("test.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Parser.RemoveClase(listBox1.SelectedIndex);
            fill();
        }
    }
}
