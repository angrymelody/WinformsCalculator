using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        String option;
        int result;

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button10.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtDisplay.Text);
            if (option == ("+"))
                result = num1 + num2;

            if (option == ("-"))
                result = num1 - num2;

            if (option ==("*"))
                result = num1 * num2;

            if (option ==("/"))
                result = num1 / num2;

            txtDisplay.Text = result + "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
