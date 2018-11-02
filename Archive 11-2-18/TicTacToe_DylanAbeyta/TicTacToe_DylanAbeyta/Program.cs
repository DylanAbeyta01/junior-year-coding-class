using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_DylanAbeyta
{
    class Program
    {
        static int y = 0;
        static int x = 0;
        static bool tie = false;
        static string[,] array = new string[3, 3];

        static void Main(string[] args)
        {

            intro();
            do
            {
                tie = true;
                player1();
                player2();

            } while (tie == true);
        Console.ReadKey();
        }

        static void player1()
        {
            Console.WriteLine("Player 1");
            Console.WriteLine("enter cordinates for the horizontal point");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("enter cordinates for the vertical point");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("vertical value: " + y);
            Console.WriteLine("horizontal value: " + x);

            array[x, y] = "X";
            print(array);
        }
        static void player2()
        {
            Console.WriteLine("Player 2");
            Console.WriteLine("enter cordinates for the horizontal point");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("enter cordinates for the vertical point");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("vertical value: " + y);
            Console.WriteLine("horizontal value: " + x);

            array[x, y] = "O";
            print(array);
        
        }
        static void intro()
        {
            Console.WriteLine("Welcome to Tic Tac Toe, you are X's and i am O's");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = " ";
                }                
            }
        }
        
        static int evaluate()
        {
            
            int num = 0;
            return num;
        }
        static void print(string[,] array)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j  = 0; j < 3; j++)
                {
                    Console.Write("|" + array[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
    }
}
