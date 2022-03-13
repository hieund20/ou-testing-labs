using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Calculator.Calculation;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Calculation cal = new Calculation(int.Parse(textBoxNum1.Text), int.Parse(textBoxNum2.Text));
            textBoxResult.Text = cal.Execute("+").ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Calculation cal = new Calculation(int.Parse(textBoxNum1.Text), int.Parse(textBoxNum2.Text));
            textBoxResult.Text = cal.Execute("-").ToString();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            Calculation cal = new Calculation(int.Parse(textBoxNum1.Text), int.Parse(textBoxNum2.Text));
            textBoxResult.Text = cal.Execute("*").ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            Calculation cal = new Calculation(int.Parse(textBoxNum1.Text), int.Parse(textBoxNum2.Text));
            textBoxResult.Text = cal.Execute("/").ToString();
        }
    }
}
