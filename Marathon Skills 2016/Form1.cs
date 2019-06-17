using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2016
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marathon_Skills_2016___Login fr3 = new Marathon_Skills_2016___Login();
            fr3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marathon_Skills_2016___Register_as_runner fr2 = new Marathon_Skills_2016___Register_as_runner();
            fr2.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marathon_Skills_2016___Registration_confirmation fr6 = new Marathon_Skills_2016___Registration_confirmation();
            fr6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marathon_Skills_2016___Find_out_more_information fr8 = new Marathon_Skills_2016___Find_out_more_information();
            fr8.Show();
        }
    }
}
