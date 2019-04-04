using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroWindowsForms
{
    public partial class Form1 : Form
    {
        List<string> num = new List<string>();

        public Form1()
        {
            InitializeComponent();
            Button_hello.MouseEnter += (o, e) => ChangeColor(Color.Red);
            Button_hello.MouseLeave += (o, e) => ChangeColor(Color.Blue);
        }

        public void ChangeColor(Color c)
        {
            Button_hello.BackColor = c;
        }

        private void Button_hello_Click(object sender, EventArgs e)
        {
            if (checkBox_FailSafe.Checked && dateTimePicker.Value < DateTime.Now)
            {
                Environment.Exit(0);
            }
            else
            {
                Bitmap b = new Bitmap(pictureBox.Width, pictureBox.Height);
                Random rand = new Random();
                for (int x = 0; x < pictureBox.Width; x++)
                {
                    for (int y = 0; y < pictureBox.Height; y++)
                    {
                        b.SetPixel(x, y, rand.Next(0, 2) == 0 ? Color.Red : Color.Blue);
                    }
                }
                pictureBox.Image = b;

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Leave")
            {
                Thread.Sleep(2000);
                Environment.Exit(0);
            }                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num.Add("1");
            textBox2.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num.Add("2");
            textBox2.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num.Add("3");
            textBox2.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num.Add("4");
            textBox2.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num.Add("5");
            textBox2.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num.Add("6");
            textBox2.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num.Add("7");
            textBox2.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num.Add("8");
            textBox2.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num.Add("9");
            textBox2.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.Text = "+";
            num.Add("10");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.Text = "-";
            num.Add("11");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < num.Count; i++)
            {               
                if (num[i] == "10")
                {
                    int Answer = int.Parse(num[i - 1]) + int.Parse(num[i + 1]);
                    textBox2.Clear();
                    textBox2.Text = Answer.ToString();
                    num.Clear();
                }

                else if (num[i] == "11")
                {
                    int Answer = int.Parse(num[i - 1]) - int.Parse(num[i + 1]);
                    textBox2.Clear();                   
                    textBox2.Text = Answer.ToString();
                    num.Clear();
                }

                else if (num[i] == "14")
                {
                    int Answer = int.Parse(num[i - 1]) / int.Parse(num[i + 1]);
                    textBox2.Clear();
                    textBox2.Text = Answer.ToString();
                    num.Clear();
                }

                else if (num[i] == "15")
                {
                    int Answer = int.Parse(num[i - 1]) * int.Parse(num[i + 1]);
                    textBox2.Clear();
                    textBox2.Text = Answer.ToString();
                    num.Clear();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num.Clear();
            textBox2.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.Text = "x";
            num.Add("15");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.Text = "/";
            num.Add("14");
        }
    }
}
