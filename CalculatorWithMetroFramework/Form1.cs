using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CalculatorWithMetroFramework
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal num1, num2, result;
        int operation;

        private void inputNumber(string number)
        {
            if (textBox.Text == "0")
                textBox.Text = number;
            else
                textBox.Text += number;
        }

        private void resultCalculation ()
        {
            try
            {
                switch (operation)
                {
                    case 1:
                        result = num1 + num2;
                        textBox.Text = decimal.Round(result,5).ToString();
                        break;

                    case 2:
                        result = num1 - num2;
                        textBox.Text = decimal.Round(result, 5).ToString();
                        break;

                    case 3:
                        result = num1 * num2;
                        textBox.Text = decimal.Round(result, 5).ToString();
                        break;

                    case 4:
                        result = num1 / num2;
                        textBox.Text = decimal.Round(result, 5).ToString();
                        break; 

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            inputNumber("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            inputNumber("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            inputNumber("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            inputNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            inputNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            inputNumber("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            inputNumber("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            inputNumber("8");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            num1 = 0;
            num2 = 0;
            result = 0;
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
            {
                if (!textBox.Text.Contains("."))
                    textBox.Text += ".";
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox.Text.Trim() == string.Empty || textBox.Text.Trim() == "0")
                    MessageBox.Show("Enter Valid Number", "Error");

                num1 = Convert.ToDecimal(textBox.Text);
                operation = 1;
                textBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox.Text.Trim() == string.Empty || textBox.Text.Trim() == "0")
                    MessageBox.Show("Enter Valid Number", "Error");

                num2 = Convert.ToDecimal(textBox.Text.Trim());

                resultCalculation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void btnSubtruction_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox.Text.Trim() == string.Empty || textBox.Text.Trim() == "0")
                    MessageBox.Show("Enter Valid Number", "Error");

                num1 = Convert.ToDecimal(textBox.Text);
                operation = 2;
                textBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox.Text.Trim() == string.Empty || textBox.Text.Trim() == "0")
                    MessageBox.Show("Enter Valid Number", "Error");

                num1 = Convert.ToDecimal(textBox.Text);
                operation = 3;
                textBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox.Text.Trim() == string.Empty || textBox.Text.Trim() == "0")
                    MessageBox.Show("Enter Valid Number", "Error");

                num1 = Convert.ToDecimal(textBox.Text);
                operation = 4;
                textBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            inputNumber("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            inputNumber("0");
        }
    }
}
