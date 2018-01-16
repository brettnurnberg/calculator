using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calculator
{
    public partial class Calculator : Form
    {
        public enum operators
        {
            DOT,
            ADD,
            SUBTRACT,
            MULTIPLY,
            DIVIDE,
            EQUALS
        };

        private double run_total;
        private double current_value;

        public Calculator()
        {
            InitializeComponent();
        }

        public void eh_digit(int value)
        {
            string temp;
            temp = calc_value.Text + value.ToString();
            calc_value.Text = temp;
        }

        public void eh_operator(operators value)
        {
            string text;
            text = calc_value.Text;
            switch(value)
            {
                case operators.DOT:
                    if(!text.Contains("."))
                    {
                        calc_value.Text = value + ".";
                    }
                    break;
                case operators.ADD:

                    break;
                case operators.SUBTRACT:

                    break;
                case operators.MULTIPLY:

                    break;
                case operators.DIVIDE:

                    break;
                case operators.EQUALS:

                    break;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_0_Click(object sender, EventArgs e)
        {
            eh_digit(0);
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            eh_digit(1);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            eh_digit(2);
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            eh_digit(3);
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            eh_digit(4);
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            eh_digit(5);
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            eh_digit(6);
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            eh_digit(7);
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            eh_digit(8);
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            eh_digit(9);
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            eh_operator(operators.DOT);
        }

        private void button_plus_Click(object sender, EventArgs e)
        {

        }

        private void button_minus_Click(object sender, EventArgs e)
        {

        }

        private void button_multiply_Click(object sender, EventArgs e)
        {

        }

        private void button_divide_Click(object sender, EventArgs e)
        {

        }

        private void button_equals_Click(object sender, EventArgs e)
        {

        }
    }


}
