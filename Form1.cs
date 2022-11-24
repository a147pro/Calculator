namespace Calculator
{
    public partial class Form1 : Form
        //
        //
        // Sorry gordon it only does single digit numbers :(
        //
        //

    {
        public Form1()
        {
            InitializeComponent();
        }
        double firstNumber;
        string mathSymbol = "";
        double secondNumber;
        double total;
        int next = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object firstNumber, EventArgs e)
        {
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = "0";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (next == 0)
            {
                textBoxOutput.Text = "1";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (next == 0)
            {
                textBoxOutput.Text = "2";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (next == 0)
            {
                textBoxOutput.Text = "3";
 
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (next == 0)
            {
                textBoxOutput.Text = "4";
            }

                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (next == 0)
            {
                textBoxOutput.Text = "5";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (next == 0)
            {
                textBoxOutput.Text = "6";

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (next == 0)
            {
                textBoxOutput.Text = "7";

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (next == 0)
            {
                textBoxOutput.Text = "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (next == 0)
            {
                textBoxOutput.Text = "9";

            }
        }

     

        private void buttonAc_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = " ";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = " ";
        }

        private void buttonPerecnt_Click(object sender, EventArgs e)
        {

        }

        private void display(object sender, EventArgs e)
        {
            
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            firstNumber = float.Parse(textBoxOutput.Text);
            textBoxOutput.Text = "-";
            mathSymbol = "-";

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            firstNumber = float.Parse(textBoxOutput.Text);
            textBoxOutput.Text = "+";
            mathSymbol = "+";
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = float.Parse(textBoxOutput.Text);
            textBoxOutput.Text = "x";
            mathSymbol = "*";

        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            firstNumber = float.Parse(textBoxOutput.Text);
            textBoxOutput.Text = "/";
            mathSymbol = "/";


        }
        private void buttonPoint_Click(object sender, EventArgs e)
        {
           

        }

        private void equalsButton(object sender, EventArgs e)
        {
            if (mathSymbol == "+")
            {
                secondNumber = float.Parse(textBoxOutput.Text);
                total = firstNumber + secondNumber;
                textBoxOutput.Text =firstNumber.ToString() + "+" + secondNumber.ToString() + "=" +total.ToString();
            }
            else if (mathSymbol == "-")
            {
                secondNumber = float.Parse(textBoxOutput.Text);
                total = firstNumber - secondNumber;
                textBoxOutput.Text = firstNumber.ToString() + "-" + secondNumber.ToString() + "=" + total.ToString();

            }
            else if (mathSymbol == "/")
            {
                secondNumber = float.Parse(textBoxOutput.Text);
                total = firstNumber / secondNumber;
                textBoxOutput.Text = firstNumber.ToString() + "/" + secondNumber.ToString() + "=" + total.ToString();
            }
            else if (mathSymbol == "*")
            {
                secondNumber = float.Parse(textBoxOutput.Text);
                total = firstNumber * secondNumber;
                textBoxOutput.Text = firstNumber.ToString() + "*" + secondNumber.ToString() + "=" + total.ToString();
            }
        }
    }
}