using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLearn
{
    public partial class Canvas : Form
    {
        int firstNumber = 0;
        int secondNumber = 0;
        int resultnumber = 0;
        public Canvas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultnumber = firstNumber + secondNumber;
            result.Text = resultnumber.ToString();
            if(resultnumber > 100)
            {
                progressBar1.Value = 100;
            }
            else
            {
                progressBar1.Value = resultnumber;
            }
        }

        private void secondtext_TextChanged(object sender, EventArgs e)
        {
            secondNumber = Convert.ToInt32(secondtext.Text);
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void firsttext_TextChanged(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(firsttext.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Result is " + resultnumber.ToString(),"Result Number");
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
