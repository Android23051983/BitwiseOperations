using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BitwiseOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox2.Clear();
            textBox2.Text = Convert.ToString(i, 2);
            
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox2.Clear();
            textBox2.Text += Convert.ToString(i, 16);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox2.Clear();
            textBox2.Text = Convert.ToString(i, 8);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i;
            if(String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "0";
                i = Convert.ToInt32(textBox1.Text);
            }
            else
            {
                i = Convert.ToInt32(textBox1.Text);
            }
            if (radioButton1.Checked == true)
            {
                textBox2.Clear();
                textBox2.Text = Convert.ToString(i, 2);

            }
            else if (radioButton2.Checked == true) 
            {
                textBox2.Clear();
                textBox2.Text += Convert.ToString(i, 16);

            }
            else if(radioButton3.Checked == true)
            {
                textBox2.Clear();
                textBox2.Text = Convert.ToString(i, 8);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text) | String.IsNullOrEmpty(textBox4.Text))
            {
                textBox3.Text = "16";
                textBox4.Text = "2";
                int num1 = Convert.ToInt32(textBox3.Text);
                int num2 = Convert.ToInt32(textBox4.Text);
                int result = num1 & num2;
                textBox5.Text = result.ToString();
            }
            else
            {
                int num1 = Convert.ToInt32(textBox3.Text);
                int num2 = Convert.ToInt32(textBox4.Text);
                int result = num1 & num2;
                textBox5.Text = result.ToString();
            }

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text) | String.IsNullOrEmpty(textBox4.Text))
            {
                textBox3.Text = "16";
                textBox4.Text = "2";
                int num1 = Convert.ToInt32(textBox3.Text);
                int num2 = Convert.ToInt32(textBox4.Text);
                int result = num1 | num2;
                textBox5.Text = result.ToString();
            }
            else
            {
                int num1 = Convert.ToInt32(textBox3.Text);
                int num2 = Convert.ToInt32(textBox4.Text);
                int result = num1 | num2;
                textBox5.Text = result.ToString();
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text) | String.IsNullOrEmpty(textBox4.Text))
            {
                textBox3.Text = "16";
                textBox4.Text = "2";
                int num1 = Convert.ToInt32(textBox3.Text);
                int num2 = Convert.ToInt32(textBox4.Text);
                int result = num1 ^ num2;
                textBox5.Text = result.ToString();
            }
            else
            {
                int num1 = Convert.ToInt32(textBox3.Text);
                int num2 = Convert.ToInt32(textBox4.Text);
                int result = num1 ^ num2;
                textBox5.Text = result.ToString();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(textBox3.Text) | String.IsNullOrEmpty(textBox4.Text))
            {
                textBox3.Text = "16";
                textBox4.Text = "2";
                int num1 = Convert.ToInt32(textBox3.Text);
                int num2 = Convert.ToInt32(textBox4.Text);
                int result = num1 << num2;
                int result2 = result << 1;
                textBox5.Text = result2.ToString();
            }
            else
            {
                int num1 = Convert.ToInt32(textBox3.Text);
                int num2 = Convert.ToInt32(textBox4.Text);
                int result = num1 << num2;
                int result2 = result << 1;
                textBox5.Text = result2.ToString();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox3.Text) | String.IsNullOrEmpty(textBox4.Text))
            {
                textBox3.Text = "16";
                textBox4.Text = "2";
                int num1 = Convert.ToInt32(textBox3.Text);
                int num2 = Convert.ToInt32(textBox4.Text);
                int result = num1 << num2;
                int result2 = result << num2;
                textBox5.Text = result2.ToString();
            }
            else
            {
                int num1 = Convert.ToInt32(textBox3.Text);
                int num2 = Convert.ToInt32(textBox4.Text);
                int result = num1 << num2;
                int result2 = result << num2;
                textBox5.Text = result2.ToString();
            }
        }
    }
}
