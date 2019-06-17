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
    public partial class Marathon_Skills_2016___Find_out_more_information : Form
    {
        public Marathon_Skills_2016___Find_out_more_information()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr1 = new Form1();
            fr1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Marathon_Skills_2016___About_Marathon_Skills_2016 fr9 = new Marathon_Skills_2016___About_Marathon_Skills_2016();
            fr9.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marathon_Skills_2015__BMR_calculator fr24 = new Marathon_Skills_2015__BMR_calculator();
            fr24.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marathon_Skills_2015___BMI_calculator fr23 = new Marathon_Skills_2015___BMI_calculator();
            fr23.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marathon_Skills_2016___How_long_is_a_marathon fr11 = new Marathon_Skills_2016___How_long_is_a_marathon();
            fr11.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marathon_Skills_2016___My_race_results fr13 = new Marathon_Skills_2016___My_race_results();
            fr13.Show();
        }
    }
}
