using System;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        float firstOperand = 0;
        float secondOperand = 0;
        string operatorr="";
        float result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void zeroButton_Click(object sender, EventArgs e)
        {
            textBox.Text+="0";
        }
        private void oneButton_Click(object sender, EventArgs e)
        {
            showOnScreen("1");
        }
        private void twoButton_Click(object sender, EventArgs e)
        {
            showOnScreen("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            showOnScreen("3");
        }
        private void fourButton_Click(object sender, EventArgs e)
        {
            showOnScreen("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            showOnScreen("5");
        }
        private void sixButton_Click(object sender, EventArgs e)
        {
            showOnScreen("6");
        }
        private void sevenButton_Click(object sender, EventArgs e)
        {
            showOnScreen("7");
        }
        private void eightButton_Click(object sender, EventArgs e)
        {
            showOnScreen("8");
        }
        private void nineButton_Click(object sender, EventArgs e)
        {
            showOnScreen("9");
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            firstOperand=secondOperand=0;
            operatorr="";
            textBox.Text="";
        }  
        private void CEButton_Click(object sender, EventArgs e)
        {
            secondOperand=0;
            textBox.Text="";
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text!="")
            {
                string text = textBox.Text;
                textBox.Text = text.Substring(0, text.Length - 1);
            }
        }
        private void plusButton_Click(object sender, EventArgs e)
        {
            handleOperator("+");
        }
        private void minusButton_Click(object sender, EventArgs e)
        {
            handleOperator("-");
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            handleOperator("/");
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            handleOperator("*");
        }
        private void squareButton_Click(object sender, EventArgs e)
        {
            //if their is no number entered before square or its only a decimal point,, don't perform any action on it
            if ((textBox.Text=="")||(textBox.Text=="."))
                textBox.Text = "";
            else
            {
                firstOperand = float.Parse(textBox.Text);
                operatorr="^";
            }
        }
        private void equalButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text=="")
                textBox.Text = "";
            else
            {
                secondOperand = float.Parse(textBox.Text);
                switch(operatorr)
                {
                    case "+":
                        result=firstOperand+secondOperand;
                        break;
                    case "-":
                        result=firstOperand-secondOperand;
                        break;
                    case "*":
                        result=firstOperand*secondOperand;
                        break;
                    case "/":
                        result=firstOperand/secondOperand;
                        break;
                    case "^":
                        result=firstOperand*firstOperand; //calculate square of a number even if a number is entered after square operator
                        break;
                    default:
                        result=firstOperand; //if no operator is entered after a first operand, result is the only number entered
                        break;
                }
                textBox.Text=result.ToString();
                //set operator and operands value to default values
                firstOperand=secondOperand=0;
                operatorr="";
            }
        }
      
        private void pointButton_Click(object sender, EventArgs e)
        {
            string text = textBox.Text;
            //only consider point if there is a already a number entered and point doesn't exist already
            if ((text!="0")&&(!text.Contains("."))&&(text!=""))
                textBox.Text+=".";
        }
        private void showOnScreen(string num)
        {
            if (textBox.Text!="0")
                textBox.Text+=num;
            else
                textBox.Text=num;
        }
        private void handleOperator(string op)
        {
            //if their is no number entered before this operatot or its only a decimal point,, don't perform any action on it
            if ((textBox.Text=="")||(textBox.Text=="."))
                textBox.Text = "";
            else
            {
                firstOperand = float.Parse(textBox.Text);
                operatorr=op;
                textBox.Text="";
            }
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}
