using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ggiptoject1
{

    public partial class Form1 : Form
    {
        enum Operators
        {
            None,
            Add,
            Minus,
            Cob,
            Divied,
            Result
        }
        Operators  currntOperators = Operators.None;
        Boolean operatorChangeFlage = false;
        int firstOperand = 0;
        int secondOperand = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {
            secondOperand = Int32.Parse(display.Text);
            if (currntOperators == Operators.Add)
            {
                firstOperand += secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currntOperators == Operators.Minus)
            {
                firstOperand -= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currntOperators == Operators.Cob)
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currntOperators == Operators.Divied)
            {
                if (secondOperand == 0)
                {
                    display.Text = "0으로 나눌수 없습니다.";
                }
                else 
                { 
                firstOperand /= secondOperand;
                display.Text = firstOperand.ToString();
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currntOperators = Operators.Add;
            operatorChangeFlage = true;

        }

        private void minus_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currntOperators = Operators.Minus;
            operatorChangeFlage = true;

        }

        private void cob_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currntOperators = Operators.Cob;
            operatorChangeFlage = true;

        }

        private void divied_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currntOperators = Operators.Divied;
            operatorChangeFlage = true;

        }

        private void ac_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currntOperators = Operators.None;
            display.Text = "0";

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlage == true)
            {
                display.Text = "";
                operatorChangeFlage = false;
            }

            string strnumber = display.Text += "0";
            int intNumber = Int32.Parse(strnumber);
            display.Text = intNumber.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlage == true)
            {
                display.Text = "";
                operatorChangeFlage = false;
            }
           
            string strnumber = display.Text += "1";
            int intNumber = Int32.Parse(strnumber);
            display.Text = intNumber.ToString();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (operatorChangeFlage == true)
            {
                display.Text = "";
                operatorChangeFlage = false;
            }

            string strnumber = display.Text += "2";
            int intNumber = Int32.Parse(strnumber);
            display.Text = intNumber.ToString();
        }

        private void display_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlage == true)
            {
                display.Text = "";
                operatorChangeFlage = false;
            }

            string strnumber = display.Text += "3";
            int intNumber = Int32.Parse(strnumber);
            display.Text = intNumber.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlage == true)
            {
                display.Text = "";
                operatorChangeFlage = false;
            }

            string strnumber = display.Text += "4";
            int intNumber = Int32.Parse(strnumber);
            display.Text = intNumber.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlage == true)
            {
                display.Text = "";
                operatorChangeFlage = false;
            }

            string strnumber = display.Text += "5";
            int intNumber = Int32.Parse(strnumber);
            display.Text = intNumber.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlage == true)
            {
                display.Text = "";
                operatorChangeFlage = false;
            }

            string strnumber = display.Text += "6";
            int intNumber = Int32.Parse(strnumber);
            display.Text = intNumber.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlage == true)
            {
                display.Text = "";
                operatorChangeFlage = false;
            }

            string strnumber = display.Text += "7";
            int intNumber = Int32.Parse(strnumber);
            display.Text = intNumber.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlage == true)
            {
                display.Text = "";
                operatorChangeFlage = false;
            }

            string strnumber = display.Text += "8";
            int intNumber = Int32.Parse(strnumber);
            display.Text = intNumber.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlage == true)
            {
                display.Text = "";
                operatorChangeFlage = false;
            }

            string strnumber = display.Text += "9";
            int intNumber = Int32.Parse(strnumber);
            display.Text = intNumber.ToString();
        }
    }
}
