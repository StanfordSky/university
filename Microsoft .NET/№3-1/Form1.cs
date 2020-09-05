using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_1
{
    public partial class Form1 : Form
    {

        // ------ Constructor ------ // 
        public Form1()
        {
            InitializeComponent();

        }


        // ------ Tab Control #1  ------ // 
        /* -- NumericUpDown -- */
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";

            for (int i = 1; i < numericUpDown1.Value; i++)
            {
                textBox1.Text = textBox1.Text + " " + i.ToString();
            }
        }



        // ------ Tab Control #2  ------ // \
        /* -- Button #1 -- */
        private void button1_Click(object sender, EventArgs e)
        {
            string[] words = textBox2.Text.Split(' ', ',', '.', '!');
            for (int i = 0; i < words.Length; i++)
            {
                if(words[i].ToString() != "")
                {
                    comboBox1.Items.Add(words[i].ToString());
                   
                }
            }
        }

        /* -- Button #2 -- */
        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();   
        }

        /* -- ComboBox #1 -- */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.Items[comboBox1.SelectedIndex].ToString();
        }



        // ------ Tab Control #3  ------ // 
        /* -- Variable for math operation(+,-,*,/) -- */
        double NumberOne = 0, 
               NumberTwo = 0;

        /* -- Button #3 -> "+" -- */
        private void button3_Click(object sender, EventArgs e)
        {
            if (Validation())
                textBox6.Text = (NumberOne + NumberTwo).ToString();
        }

        /* -- Button #4 -> "-" -- */
        private void button4_Click(object sender, EventArgs e)
        {
            if (Validation())
                textBox6.Text = (NumberOne - NumberTwo).ToString();
        }

        /* -- Button #5 -> "*" -- */
        private void button5_Click(object sender, EventArgs e)
        {
            if (Validation())
                textBox6.Text = (NumberOne * NumberTwo).ToString();
        }

        /* -- Button #6 -> "*" -- */
        private void button6_Click(object sender, EventArgs e)
        {
            if (Validation() && Convert.ToDouble(textBox5.Text) != 0)
            {
                textBox6.Text = (NumberOne / NumberTwo).ToString();
            }
            else if (Convert.ToDouble(textBox5.Text) == 0)
            {
                ErrorNotitication();
            }
        }

        /* -- Validation data -- */
        private bool Validation()
        {
            try
            {
                NumberOne = Convert.ToDouble(textBox4.Text);
                NumberTwo = Convert.ToDouble(textBox5.Text);
                return true;
            }
            catch
            {
                ErrorNotitication();
                return false;
            }
        }


        private void ErrorNotitication()
        {
            NotifyIcon notification = new NotifyIcon();
            notification.BalloonTipIcon = ToolTipIcon.Error;
            notification.BalloonTipTitle = "Error in intial data";
            notification.BalloonTipText = "Failed to complete the intended operation.";
            notification.Icon = this.Icon;
            notification.Visible = true;
            notification.ShowBalloonTip(4000);
        }


        // ------ Tab Control #4  ------ // 
        private void button7_Click(object sender, EventArgs e)
        {
            string[] strings = textBox7.Text.Split('\n');


            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].ToString() != "")
                {
                    try
                    {
                        comboBox2.Items.Add((Convert.ToDouble(strings[i])).ToString());
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }
        }


        // ------ Tab Control #5  ------ //
        private void button8_Click(object sender, EventArgs e)
        {
            double sumbefore = 0,
                    sumafter = 0,
                    accuraty = Convert.ToDouble(numericUpDown2.Value);
            textBox8.Text = " ";
            double x = 1;

            while (true)
            {
                sumafter += 1 / x;
                textBox8.Text += "Sum = " + sumafter + "\r\n";
                if (sumafter - sumbefore < accuraty)
                {
                    return;
                }
                x+=1000;
                sumbefore = sumafter;
            }
        }


        // ------ Tab Control #6  ------ //
    }
}




