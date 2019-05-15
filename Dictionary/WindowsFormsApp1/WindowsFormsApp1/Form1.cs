using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.LightGreen;
            btn1.ForeColor = Color.Black;

            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                { "Apple", "$2.50"},
                { "Orange", "$1.50"},
                { "Kiwifruit", "$3.00"}
            };
            foreach(KeyValuePair<string, string> fruit in dict)
            {
                listBox1.Items.Add($"Fruit: {fruit.Key} Price: {fruit.Value}");
            }
        }
    }
}
