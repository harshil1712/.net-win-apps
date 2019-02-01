using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arth_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ans = Convert.ToInt16(inputA.Text) + Convert.ToInt16(inputB.Text);
            label1.Text = "Answer: " + ans.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sub_Click(object sender, EventArgs e)
        {
            int ans = Convert.ToInt16(inputA.Text) - Convert.ToInt16(inputB.Text);
            label1.Text = "Answer: " + ans.ToString();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            int ans = Convert.ToInt16(inputA.Text) * Convert.ToInt16(inputB.Text);
            label1.Text = "Answer: " + ans.ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            double ans = Convert.ToDouble(inputA.Text) / Convert.ToDouble(inputB.Text);
            label1.Text = "Answer: " + ans.ToString();
        }
    }
}
