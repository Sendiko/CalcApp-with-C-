using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        string userInput = "";
            

        string firstNum = "";
        string secondNum = "";
        char fun;
        double result = 0.0;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "0";
            calculatorDisplay.Text += userInput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput = "1";
            calculatorDisplay.Text += userInput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "2";
            calculatorDisplay.Text += userInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "3";
            calculatorDisplay.Text += userInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "4";
            calculatorDisplay.Text += userInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "5";
            calculatorDisplay.Text += userInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "6";
            calculatorDisplay.Text += userInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "7";
            calculatorDisplay.Text += userInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "8";
            calculatorDisplay.Text += userInput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "9";
            calculatorDisplay.Text += userInput;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            fun = '-';
            firstNum = userInput;
            userInput = "";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            fun = '+';
            firstNum = userInput;
            userInput = "";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            fun = '*';
            firstNum = userInput;
            userInput = "";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            fun = '/';
            firstNum = userInput;
            userInput = "";
        }

        private void buttonDecimals_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = ".";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            secondNum = userInput;
            double first, second;
            first = Convert.ToDouble(firstNum);
            second = Convert.ToDouble(secondNum);

            if (fun == '+')
            {
                result = first + second;
                calculatorDisplay.Text = result.ToString();
            }
            else if (fun == '-')
            {
                result = first - second;
                calculatorDisplay.Text = result.ToString();
            }
            else if (fun == '*')
            {
                result = first * second;
                calculatorDisplay.Text = result.ToString();
            }
            else if (fun == '/')
            {
                if(second == 0)
                {
                    calculatorDisplay.Text = "can't divide 0";
                }
                else
                {
                    result = first / second;
                    calculatorDisplay.Text = result.ToString();
                }
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            userInput = "";
            firstNum = "";
            secondNum = "";
            result = 0.0;
            calculatorDisplay.Text = "0";
        }
    }
}
