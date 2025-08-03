using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private float number1;
        private float number2;
        private float result;
        private string operation;

        public Calculator()
        {
            InitializeComponent();

            foreach (var btn in new[] { BtnNumber0, BtnNumber1, BtnNumber2, BtnNumber3, BtnNumber4, BtnNumber5, BtnNumber6, BtnNumber7, BtnNumber8, BtnNumber9 })
                btn.Click += Numbers_Click;

            foreach (var btn in new[] { BtnPlus, BtnMinus, BtnMultiply, BtnDivide })
                btn.Click += Operators_Click;

            BtnResult.Click += BtnResult_Click;

            BtnClear.Click += (s, e) => ClearFields();
        }

        private void Numbers_Click(object sender, EventArgs e)
        {
            TbDisplay.Text += ((Button)sender).Text;
        }

        private void Operators_Click(object sender, EventArgs e)
        {
            float.TryParse(TbDisplay.Text, out number1);
            operation = ((Button)sender).Text;
            TbDisplay.Clear();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(TbDisplay.Text, out number2)) return;

            result = operation switch
            {
                "+" => number1 + number2,
                "-" => number1 - number2,
                "*" => number1 * number2,
                "/" when number2 != 0 => number1 / number2,
                "/" => float.NaN,
                _ => 0
            };

            TbDisplay.Text = float.IsNaN(result) ? "Divide by zero" : result.ToString();
        }

        private void ClearFields()
        {
            TbDisplay.Clear();
            number1 = number2 = result = 0;
            operation = string.Empty;
        }
    }
}
