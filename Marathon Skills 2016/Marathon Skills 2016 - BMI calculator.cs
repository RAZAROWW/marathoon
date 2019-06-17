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
    public partial class Marathon_Skills_2015___BMI_calculator : Form
    {
        public Marathon_Skills_2015___BMI_calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marathon_Skills_2016___Find_out_more_information fr8 = new Marathon_Skills_2016___Find_out_more_information();
            fr8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Marathon_Skills_2016___Find_out_more_information frm8 = new Marathon_Skills_2016___Find_out_more_information();
            frm8.Show();
        }
    }
}
