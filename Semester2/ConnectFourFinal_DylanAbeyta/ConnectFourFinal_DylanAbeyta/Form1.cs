using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFourFinal_DylanAbeyta
{
    public partial class Form1 : Form
    {
        int player1score = 0;
        int player2score = 0;
        int player1 = 1;
        int player2 = 0;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = ("Player 1 Wins: " + player1score);
            textBox2.Text = ("Player 2 Wins: " + player2score);
                        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (player1 == 1)
            {
                if (pictureBo6.BackColor != Color.Blue && pictureBo6.BackColor != Color.Red)
                {
                    pictureBo6.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo7.BackColor != Color.Blue && pictureBo7.BackColor != Color.Red)
                {
                    pictureBo7.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo8.BackColor != Color.Blue && pictureBo8.BackColor != Color.Red)
                {
                    pictureBo8.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo9.BackColor != Color.Blue && pictureBo9.BackColor != Color.Red)
                {
                    pictureBo9.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo10.BackColor != Color.Blue && pictureBo10.BackColor != Color.Red)
                {
                    pictureBo10.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
            }
            else if (player2 == 1)
            {
                if (pictureBo6.BackColor != Color.Blue && pictureBo6.BackColor != Color.Red)
                {
                    pictureBo6.BackColor = Color.Red;
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo7.BackColor != Color.Blue && pictureBo7.BackColor != Color.Red)
                {
                    pictureBo7.BackColor = Color.Red;
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo8.BackColor != Color.Blue && pictureBo8.BackColor != Color.Red)
                {
                    pictureBo8.BackColor = Color.Red;
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo9.BackColor != Color.Blue && pictureBo9.BackColor != Color.Red)
                {
                    pictureBo9.BackColor = Color.Red;
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo10.BackColor != Color.Blue && pictureBo10.BackColor != Color.Red)
                {
                    pictureBo10.BackColor = Color.Red;
                    player2 = 0;
                    player2++;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (player1 == 1)
            {
                if (pictureBo1.BackColor != Color.Blue && pictureBo1.BackColor != Color.Red)
                {
                    pictureBo1.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo2.BackColor != Color.Blue && pictureBo2.BackColor != Color.Red)
                {
                    pictureBo2.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo3.BackColor != Color.Blue && pictureBo3.BackColor != Color.Red)
                {
                    pictureBo3.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo4.BackColor != Color.Blue && pictureBo4.BackColor != Color.Red)
                {
                    pictureBo4.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo5.BackColor != Color.Blue && pictureBo5.BackColor != Color.Red)
                {
                    pictureBo5.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                } 
            }
            else if (player2 == 1)
            {
                if (pictureBo1.BackColor != Color.Blue && pictureBo1.BackColor != Color.Red)
                {
                    pictureBo1.BackColor = Color.Red;
                    player2 = 0;
                    player1++;              
                }
                else if (pictureBo2.BackColor != Color.Blue && pictureBo2.BackColor != Color.Red)
                {
                    pictureBo2.BackColor = Color.Red;
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo3.BackColor != Color.Blue && pictureBo3.BackColor != Color.Red)
                {
                    pictureBo3.BackColor = Color.Red;
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo4.BackColor != Color.Blue && pictureBo4.BackColor != Color.Red)
                {
                    pictureBo4.BackColor = Color.Red;
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo5.BackColor != Color.Blue && pictureBo5.BackColor != Color.Red)
                {
                    pictureBo5.BackColor = Color.Red;
                    player2 = 0;
                    player2++;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (player1 == 1)
            {
                if (pictureBo11.BackColor != Color.Blue && pictureBo11.BackColor != Color.Red)
                {
                    pictureBo11.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo12.BackColor != Color.Blue && pictureBo12.BackColor != Color.Red)
                {
                    pictureBo12.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo13.BackColor != Color.Blue && pictureBo13.BackColor != Color.Red)
                {
                    pictureBo13.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo14.BackColor != Color.Blue && pictureBo14.BackColor != Color.Red)
                {
                    pictureBo14.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo15.BackColor != Color.Blue && pictureBo15.BackColor != Color.Red)
                {
                    pictureBo15.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
            }
            else if (player2 == 1)
            {
                if (pictureBo11.BackColor != Color.Blue && pictureBo11.BackColor != Color.Red)
                {
                    pictureBo11.BackColor = Color.Red;
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo12.BackColor != Color.Blue && pictureBo12.BackColor != Color.Red)
                {
                    pictureBo12.BackColor = Color.Red;
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo13.BackColor != Color.Blue && pictureBo13.BackColor != Color.Red)
                {
                    pictureBo13.BackColor = Color.Red;
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo14.BackColor != Color.Blue && pictureBo14.BackColor != Color.Red)
                {
                    pictureBo14.BackColor = Color.Red;
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo15.BackColor != Color.Blue && pictureBo15.BackColor != Color.Red)
                {
                    pictureBo15.BackColor = Color.Red;
                    player2 = 0;
                    player2++;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (player1 == 1)
            {
                if (pictureBo16.BackColor != Color.Blue && pictureBo16.BackColor != Color.Red)
                {
                    pictureBo16.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo17.BackColor != Color.Blue && pictureBo17.BackColor != Color.Red)
                {
                    pictureBo17.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo18.BackColor != Color.Blue && pictureBo18.BackColor != Color.Red)
                {
                    pictureBo18.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo19.BackColor != Color.Blue && pictureBo19.BackColor != Color.Red)
                {
                    pictureBo19.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo20.BackColor != Color.Blue && pictureBo20.BackColor != Color.Red)
                {
                    pictureBo20.BackColor = Color.Blue;
                    player1 = 0;
                    player2++;
                }
            }
            else if (player2 == 1)
            {
                if (pictureBo16.BackColor != Color.Blue && pictureBo16.BackColor != Color.Red)
                {
                    pictureBo16.BackColor = Color.Red;
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo17.BackColor != Color.Blue && pictureBo17.BackColor != Color.Red)
                {
                    pictureBo17.BackColor = Color.Red;
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo18.BackColor != Color.Blue && pictureBo18.BackColor != Color.Red)
                {
                    pictureBo18.BackColor = Color.Red;
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo19.BackColor != Color.Blue && pictureBo19.BackColor != Color.Red)
                {
                    pictureBo19.BackColor = Color.Red;
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo20.BackColor != Color.Blue && pictureBo20.BackColor != Color.Red)
                {
                    pictureBo20.BackColor = Color.Red;
                    player2 = 0;
                    player2++;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
