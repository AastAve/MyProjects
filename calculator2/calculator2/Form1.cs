using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        public string currentOperator;
        public double result;
        public string d;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentOperator = "-";
            label2.Text = Convert.ToString("-");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RationalNumber rat1 = new RationalNumber(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox4.Text));
            RationalNumber rat2 = new RationalNumber(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox5.Text));

            RationalNumber result = new RationalNumber(0, 1);
            

            switch (currentOperator)
            {
                case "-":
                    result = rat1 - rat2;
                    break;
                case "+":
                    result= rat1 + rat2;
                    break;
                case "*":
                   result= rat1  *rat2;
                    break;
                case "/":
                  result= rat1 / rat2;
                    break;
            }
            textBox3.Text = Convert.ToString(result.c);
            textBox6.Text = Convert.ToString(result.z);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentOperator = "*";
            label2.Text = Convert.ToString("*");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentOperator = "+";
            label2.Text = Convert.ToString("+");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentOperator = "/";
            label2.Text = Convert.ToString("/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentOperator = "0";

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
