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
    public partial class Marathon_Skills_2016___My_race_results : Form
    {
        public Marathon_Skills_2016___My_race_results()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr1 = new Form1();
            fr1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marathon_Skills_2016___Runner_menu fr7 = new Marathon_Skills_2016___Runner_menu();
            fr7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marathon_Skills_2016___Coordinator_menu fr13 = new Marathon_Skills_2016___Coordinator_menu();
            fr13.Show();
        }
    }
}
