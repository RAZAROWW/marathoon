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
    public partial class Marathon_Skills_2016___Coordinator_menu : Form
    {
        public Marathon_Skills_2016___Coordinator_menu()
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
            Marathon_Skills_2016__Runner_management fr16 = new Marathon_Skills_2016__Runner_management();
            fr16.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr1 = new Form1();
            fr1.Show();
        }
    }
}
