using Fast_count.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_count
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
            
        public static int timerDuration;
        

        private void startButton_Click(object sender, EventArgs e)
        {
            timerDuration = int.Parse(textBox1.Text)*60;


            if (checkBox1.Checked == true)
            {
                timerDuration = int.Parse(textBox1.Text) * 60;
                Tasks2 t = new Tasks2();
                t.Visible = true;
                this.Hide();
            }
            else
            {
                timerDuration = int.Parse(textBox1.Text) * 60;
                Tasks t = new Tasks();
                t.Visible = true;
                this.Hide();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
