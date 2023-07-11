using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        float num1;
        float num2;
        float result;
        string operation;
        string divByZeroError;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)     // Button 0
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button13_Click(object sender, EventArgs e)     // Plus Operator
        {
            operation = "+";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)     // Minus Operator
        {
            operation = "-";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)     // Multiplication Operator
        {
            operation = "*";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)     // Division Operator
        {
            operation = "/";
            num1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)     // Equals Operator
        {
            num2 = int.Parse(textBox1.Text);

            if (operation == "+")
                result = num1 + num2;

            if (operation == "-")
                result = num1 - num2;

            if (operation == "*")
                result = num1 * num2;

            if (operation == "/")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }

                else
                {
                    divByZeroError = "Division by Zero Error";
                    textBox1.Text = divByZeroError + "";
                }
            }

            textBox1.Text = result + "";
        }

        private void button12_Click(object sender, EventArgs e)     // Clear Button
        {
            textBox1.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)       // Display Box
        {

        }
    }
}
