using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_task2
{
    public partial class Form1 : Form
    {
        static double[] numbers;
        static int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            numbers = new double[10];
            if (counter <= 9)
            {
                if (double.TryParse(textBox1.Text, out numbers[counter]))
                {

                    counter++;
                    btn1.Text = $"Add number {counter + 1}";
                    textBox1.ForeColor = Color.LightGray;
                    textBox1.Text = $"Enter your numbers here .....";
                }
                else if (!double.TryParse(textBox2.Text, out numbers[counter]))
                {
                    textBox2.ForeColor = Color.LightGray;
                    textBox2.Text = $"Enter your numbers here .....";
                }
                if (counter > 9)
                {
                    textBox1.Visible = false;
                    btnDisplay.Visible = true;
                    textBox1Instructions.Text = "Thankyou, all 10 numbers have been input...";
                }
            }
           
        }
    }
    
}
