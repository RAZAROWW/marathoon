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
    public partial class Marathon_Skills_2016___Manage_a_runner : Form
    {
        public Marathon_Skills_2016___Manage_a_runner()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr1 = new Form1();
            fr1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marathon_Skills_2016___Certificate_preview fr19 = new Marathon_Skills_2016___Certificate_preview();
            fr19.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marathon_Skills_2016__Runner_management fr16 = new Marathon_Skills_2016__Runner_management();
            fr16.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marathon_Skills_2016___Certificate_preview fr19 = new Marathon_Skills_2016___Certificate_preview();
            fr19.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marathon_Skills_2016___Edit_runner_profile fr18 = new Marathon_Skills_2016___Edit_runner_profile();
            fr18.Show();
        }
    }
}
