using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_count.Properties
{
    public partial class Tasks : Form
    {

        private int duration;
        private int tk;
        private string answer;
        private bool multiplication;

        public Tasks()
        {
            InitializeComponent();
            generate_Task();
            duration = Form1.timerDuration;

            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Tasks_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Количество ответов:  " + label9.Text);
            Form1 f = new Form1();
            f.Visible = true;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tk = --duration;
            TimeSpan span = TimeSpan.FromMinutes(tk);
            string label = span.ToString(@"hh\:mm");
            label6.Text = label.ToString();
            if (duration < 0)
                timer1.Stop();
        }

        private void generate_Task()
        {
            int first, second, result;

            Random rnd = new Random();
            first = rnd.Next(0,10);
            second = rnd.Next(0, 10);

            if (first > second)
            {
                label7.Text = first.ToString() + "-" + second.ToString();
                result = first - second;
                answer = result.ToString();
            }
            else
            {   
                if (multiplication == true) {
                    multiplication = false;
                    label7.Text = first.ToString() + "*" + second.ToString();
                    result = first * second;
                    answer = result.ToString();
                } else
                {
                    multiplication = true;
                    label7.Text = first.ToString() + "+" + second.ToString();
                    result = first + second;
                    answer = result.ToString();
                }

            }
        }
        int ch = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            ch++;
            label9.Text = ch.ToString(); ;
            label8.Text = answer;
            generate_Task();
        }
    }
}
