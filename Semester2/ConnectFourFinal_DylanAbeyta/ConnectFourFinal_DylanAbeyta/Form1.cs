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
        bool ifWon = false;
        List<int> Player1 = new List<int>();
        List<int> Player2 = new List<int>();

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
                    Player1.Add(6);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo7.BackColor != Color.Blue && pictureBo7.BackColor != Color.Red)
                {
                    pictureBo7.BackColor = Color.Blue;
                    Player1.Add(7);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo8.BackColor != Color.Blue && pictureBo8.BackColor != Color.Red)
                {
                    pictureBo8.BackColor = Color.Blue;
                    Player1.Add(8);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo9.BackColor != Color.Blue && pictureBo9.BackColor != Color.Red)
                {
                    pictureBo9.BackColor = Color.Blue;
                    Player1.Add(9);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo10.BackColor != Color.Blue && pictureBo10.BackColor != Color.Red)
                {
                    pictureBo10.BackColor = Color.Blue;
                    Player1.Add(10);
                    player1 = 0;
                    player2++;
                }
                ifWon = didWin();
                testrun();
            }
            else if (player2 == 1)
            {
                if (pictureBo6.BackColor != Color.Blue && pictureBo6.BackColor != Color.Red)
                {
                    pictureBo6.BackColor = Color.Red;
                    Player2.Add(6);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo7.BackColor != Color.Blue && pictureBo7.BackColor != Color.Red)
                {
                    pictureBo7.BackColor = Color.Red;
                    Player2.Add(7);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo8.BackColor != Color.Blue && pictureBo8.BackColor != Color.Red)
                {
                    pictureBo8.BackColor = Color.Red;
                    Player2.Add(8);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo9.BackColor != Color.Blue && pictureBo9.BackColor != Color.Red)
                {
                    pictureBo9.BackColor = Color.Red;
                    Player2.Add(9);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo10.BackColor != Color.Blue && pictureBo10.BackColor != Color.Red)
                {
                    pictureBo10.BackColor = Color.Red;
                    Player2.Add(10);
                    player2 = 0;
                    player1++;
                }
                ifWon = didWin();
                testrun();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (player1 == 1)
            {
                if (pictureBo1.BackColor != Color.Blue && pictureBo1.BackColor != Color.Red)
                {
                    pictureBo1.BackColor = Color.Blue;
                    Player1.Add(1);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo2.BackColor != Color.Blue && pictureBo2.BackColor != Color.Red)
                {
                    pictureBo2.BackColor = Color.Blue;
                    Player1.Add(2);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo3.BackColor != Color.Blue && pictureBo3.BackColor != Color.Red)
                {
                    pictureBo3.BackColor = Color.Blue;
                    Player1.Add(3);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo4.BackColor != Color.Blue && pictureBo4.BackColor != Color.Red)
                {
                    pictureBo4.BackColor = Color.Blue;
                    Player1.Add(4);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo5.BackColor != Color.Blue && pictureBo5.BackColor != Color.Red)
                {
                    pictureBo5.BackColor = Color.Blue;
                    Player1.Add(5);
                    player1 = 0;
                    player2++;
                }
                ifWon = didWin();
                testrun();
            }
            else if (player2 == 1)
            {
                if (pictureBo1.BackColor != Color.Blue && pictureBo1.BackColor != Color.Red)
                {
                    pictureBo1.BackColor = Color.Red;
                    Player2.Add(1);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo2.BackColor != Color.Blue && pictureBo2.BackColor != Color.Red)
                {
                    pictureBo2.BackColor = Color.Red;
                    Player2.Add(2);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo3.BackColor != Color.Blue && pictureBo3.BackColor != Color.Red)
                {
                    pictureBo3.BackColor = Color.Red;
                    Player2.Add(3);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo4.BackColor != Color.Blue && pictureBo4.BackColor != Color.Red)
                {
                    pictureBo4.BackColor = Color.Red;
                    Player2.Add(4);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo5.BackColor != Color.Blue && pictureBo5.BackColor != Color.Red)
                {
                    pictureBo5.BackColor = Color.Red;
                    Player2.Add(5);
                    player2 = 0;
                    player1++;
                }
                ifWon = didWin();
                testrun();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (player1 == 1)
            {
                if (pictureBo11.BackColor != Color.Blue && pictureBo11.BackColor != Color.Red)
                {
                    pictureBo11.BackColor = Color.Blue;
                    Player1.Add(11);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo12.BackColor != Color.Blue && pictureBo12.BackColor != Color.Red)
                {
                    pictureBo12.BackColor = Color.Blue;
                    Player1.Add(12);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo13.BackColor != Color.Blue && pictureBo13.BackColor != Color.Red)
                {
                    pictureBo13.BackColor = Color.Blue;
                    Player1.Add(13);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo14.BackColor != Color.Blue && pictureBo14.BackColor != Color.Red)
                {
                    pictureBo14.BackColor = Color.Blue;
                    Player1.Add(14);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo15.BackColor != Color.Blue && pictureBo15.BackColor != Color.Red)
                {
                    pictureBo15.BackColor = Color.Blue;
                    Player1.Add(15);
                    player1 = 0;
                    player2++;
                }
                ifWon = didWin();
                testrun();
            }
            else if (player2 == 1)
            {
                if (pictureBo11.BackColor != Color.Blue && pictureBo11.BackColor != Color.Red)
                {
                    pictureBo11.BackColor = Color.Red;
                    Player2.Add(11);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo12.BackColor != Color.Blue && pictureBo12.BackColor != Color.Red)
                {
                    pictureBo12.BackColor = Color.Red;
                    Player2.Add(12);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo13.BackColor != Color.Blue && pictureBo13.BackColor != Color.Red)
                {
                    pictureBo13.BackColor = Color.Red;
                    Player2.Add(13);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo14.BackColor != Color.Blue && pictureBo14.BackColor != Color.Red)
                {
                    pictureBo14.BackColor = Color.Red;
                    Player2.Add(14);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo15.BackColor != Color.Blue && pictureBo15.BackColor != Color.Red)
                {
                    pictureBo15.BackColor = Color.Red;
                    Player2.Add(15);
                    player2 = 0;
                    player1++;
                }
                ifWon = didWin();
                testrun();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (player1 == 1)
            {
                if (pictureBo16.BackColor != Color.Blue && pictureBo16.BackColor != Color.Red)
                {
                    pictureBo16.BackColor = Color.Blue;
                    Player1.Add(16);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo17.BackColor != Color.Blue && pictureBo17.BackColor != Color.Red)
                {
                    pictureBo17.BackColor = Color.Blue;
                    Player1.Add(17);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo18.BackColor != Color.Blue && pictureBo18.BackColor != Color.Red)
                {
                    pictureBo18.BackColor = Color.Blue;
                    Player1.Add(18);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo19.BackColor != Color.Blue && pictureBo19.BackColor != Color.Red)
                {
                    pictureBo19.BackColor = Color.Blue;
                    Player1.Add(19);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo20.BackColor != Color.Blue && pictureBo20.BackColor != Color.Red)
                {
                    pictureBo20.BackColor = Color.Blue;
                    Player1.Add(20);
                    player1 = 0;
                    player2++;
                }
                ifWon = didWin();
                testrun();
            }
            else if (player2 == 1)
            {
                if (pictureBo16.BackColor != Color.Blue && pictureBo16.BackColor != Color.Red)
                {
                    pictureBo16.BackColor = Color.Red;
                    Player2.Add(16);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo17.BackColor != Color.Blue && pictureBo17.BackColor != Color.Red)
                {
                    pictureBo17.BackColor = Color.Red;
                    Player2.Add(17);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo18.BackColor != Color.Blue && pictureBo18.BackColor != Color.Red)
                {
                    pictureBo18.BackColor = Color.Red;
                    Player2.Add(18);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo19.BackColor != Color.Blue && pictureBo19.BackColor != Color.Red)
                {
                    pictureBo19.BackColor = Color.Red;
                    Player2.Add(19);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo20.BackColor != Color.Blue && pictureBo20.BackColor != Color.Red)
                {
                    pictureBo20.BackColor = Color.Red;
                    Player2.Add(20);
                    player2 = 0;
                    player1++;
                }
                ifWon = didWin();
                testrun();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (player1 == 1)
            {
                if (pictureBo21.BackColor != Color.Blue && pictureBo21.BackColor != Color.Red)
                {
                    pictureBo21.BackColor = Color.Blue;
                    Player1.Add(21);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo22.BackColor != Color.Blue && pictureBo22.BackColor != Color.Red)
                {
                    pictureBo22.BackColor = Color.Blue;
                    Player1.Add(22);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo23.BackColor != Color.Blue && pictureBo23.BackColor != Color.Red)
                {
                    pictureBo23.BackColor = Color.Blue;
                    Player1.Add(23);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo24.BackColor != Color.Blue && pictureBo24.BackColor != Color.Red)
                {
                    pictureBo24.BackColor = Color.Blue;
                    Player1.Add(24);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo25.BackColor != Color.Blue && pictureBo25.BackColor != Color.Red)
                {
                    pictureBo25.BackColor = Color.Blue;
                    Player1.Add(25);
                    player1 = 0;
                    player2++;
                }
                ifWon = didWin();
                testrun();
            }
            else if (player2 == 1)
            {
                if (pictureBo21.BackColor != Color.Blue && pictureBo21.BackColor != Color.Red)
                {
                    pictureBo21.BackColor = Color.Red;
                    Player2.Add(21);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo22.BackColor != Color.Blue && pictureBo22.BackColor != Color.Red)
                {
                    pictureBo22.BackColor = Color.Red;
                    Player2.Add(22);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo23.BackColor != Color.Blue && pictureBo23.BackColor != Color.Red)
                {
                    pictureBo23.BackColor = Color.Red;
                    Player2.Add(23);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo24.BackColor != Color.Blue && pictureBo24.BackColor != Color.Red)
                {
                    pictureBo24.BackColor = Color.Red;
                    Player2.Add(24);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo25.BackColor != Color.Blue && pictureBo25.BackColor != Color.Red)
                {
                    pictureBo25.BackColor = Color.Red;
                    Player2.Add(25);
                    player2 = 0;
                    player1++;
                }
                ifWon = didWin();
                testrun();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (player1 == 1)
            {
                if (pictureBo26.BackColor != Color.Blue && pictureBo26.BackColor != Color.Red)
                {
                    pictureBo26.BackColor = Color.Blue;
                    Player1.Add(26);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo27.BackColor != Color.Blue && pictureBo27.BackColor != Color.Red)
                {
                    pictureBo27.BackColor = Color.Blue;
                    Player1.Add(27);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo28.BackColor != Color.Blue && pictureBo28.BackColor != Color.Red)
                {
                    pictureBo28.BackColor = Color.Blue;
                    Player1.Add(28);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo29.BackColor != Color.Blue && pictureBo29.BackColor != Color.Red)
                {
                    pictureBo29.BackColor = Color.Blue;
                    Player1.Add(29);
                    player1 = 0;
                    player2++;
                }
                else if (pictureBo30.BackColor != Color.Blue && pictureBo30.BackColor != Color.Red)
                {
                    pictureBo30.BackColor = Color.Blue;
                    Player1.Add(30);
                    player1 = 0;
                    player2++;
                }
                ifWon = didWin();
                testrun();
            }
            else if (player2 == 1)
            {
                if (pictureBo26.BackColor != Color.Blue && pictureBo26.BackColor != Color.Red)
                {
                    pictureBo26.BackColor = Color.Red;
                    Player2.Add(26);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo27.BackColor != Color.Blue && pictureBo27.BackColor != Color.Red)
                {
                    pictureBo27.BackColor = Color.Red;
                    Player2.Add(27);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo28.BackColor != Color.Blue && pictureBo28.BackColor != Color.Red)
                {
                    pictureBo28.BackColor = Color.Red;
                    Player2.Add(28);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo29.BackColor != Color.Blue && pictureBo29.BackColor != Color.Red)
                {
                    pictureBo29.BackColor = Color.Red;
                    Player2.Add(29);
                    player2 = 0;
                    player1++;
                }
                else if (pictureBo30.BackColor != Color.Blue && pictureBo30.BackColor != Color.Red)
                {
                    pictureBo30.BackColor = Color.Red;
                    Player2.Add(30);
                    player2 = 0;
                    player1++;
                }
                ifWon = didWin();
                testrun();
            }
        }

        public bool didWin()
        {

            for (int k = 0; k < Player1.Count; k++)
            {
                if (Player1.Contains(Player1[k] + 1) && Player1.Contains(Player1[k] + 2) && Player1.Contains(Player1[k] + 3))
                {
                    return true;
                }

                if (Player1.Contains(Player1[k] + 5) && Player1.Contains(Player1[k] + 10) && Player1.Contains(Player1[k] + 15))
                {
                    return true;
                }

                if (Player1.Contains(Player1[k] + 6) && Player1.Contains(Player1[k] + 12) && Player1.Contains(Player1[k] + 18))
                {
                    return true;
                }

                if (Player1.Contains(Player1[k] + 4) && Player1.Contains(Player1[k] + 8) && Player1.Contains(Player1[k] + 12))
                {
                    if (Player1[k] != 1 && k != 2 && k != 3 && k != 6 && k != 7 && k != 8 && k != 11 && k != 12 && k != 13 &&
                    k != 16 && k != 17 && k != 18 && k != 21 && k != 22 && k != 23 && k != 26 && k != 27 && k != 28)
                    {
                        return true;
                    }
                }
            }
            Player1.Co
            for (int k = 0; k < Player2.Count; k++)
            {
                if (Player2.Contains(Player2[k] + 1) && Player2.Contains(Player2[k] + 2) && Player2.Contains(Player2[k] + 3))
                {
                    return true;
                }

                if (Player2.Contains(Player2[k] + 5) && Player2.Contains(Player2[k] + 10) && Player2.Contains(Player2[k] + 15))
                {
                    return true;
                }

                if (Player2.Contains(Player2[k] + 6) && Player2.Contains(Player2[k] + 12) && Player2.Contains(Player2[k] + 18))
                {
                    return true;
                }

                if (Player2.Contains(Player2[k] + 4) && Player2.Contains(Player2[k] + 8) && Player2.Contains(Player2[k] + 12))
                {
                    return true;
                }
            }

            


            return false;
        }

        public void testrun()
        {
            if (ifWon == true)
            {
                if (player1 == 1)
                {
                    textBox3.Text = "Congratulations Player 2 has Won";
                    player1 = 0;
                }
                else
                {
                    textBox3.Text = "Congratulations Player 1 has Won";
                    player2 = 0;
                }
            }
        }
    }
}
