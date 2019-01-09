using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_DylanAbeyta
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            int x = 0;            
            string[,] array = new string[3, 3];
            int num = 0;

            Intro(array);
            do
            {
                num = 1;
                ProcessTurn(array, 'X');
                num = Evaluate(array);
                
                if (num == 3)
                {
                    break;
                }

                ProcessTurn(array, 'O');
                num = Evaluate(array);
                
            } while (num == 2);
            if (num == 2)
            {
                Console.WriteLine("you have tied");
            }    
            if (num == 3)
            {
                Console.WriteLine("playrer 1 is the Winner");
            }
            if (num == 4)
            {
                Console.WriteLine("playrer 2 is the Winner");
            }
        Console.ReadKey();
        }
        
        static void ProcessTurn(string[,] array, char player)
        {
            do
            {
                Console.WriteLine(player);
                Console.WriteLine("enter cordinates for the horizontal point");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("enter cordinates for the vertical point");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("vertical value: " + y);
                Console.WriteLine("horizontal value: " + x);
                if (array[x, y] != " ")
                {
                    Console.WriteLine();
                    Console.WriteLine("This Cordinate is taken");
                    continue;
                }
                array[x, y] = player.ToString();
                Print(array);
                break;
            } while (true);
        }

        static void Intro(string[,] array)
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
        
        static int Evaluate(string[,] array)
        {

            if (array[0, 0] == "X" && array[0, 1] == "X" && array[0, 2] == "X" ||
                array[1, 0] == "X" && array[1, 1] == "X" && array[1, 2] == "X" ||
                array[2, 0] == "X" && array[2, 1] == "X" && array[2, 2] == "X" ||
                array[0, 0] == "X" && array[1, 0] == "X" && array[2, 0] == "X" ||
                array[0, 1] == "X" && array[1, 1] == "X" && array[2, 1] == "X" ||
                array[0, 2] == "X" && array[1, 2] == "X" && array[2, 2] == "X" ||
                array[0, 0] == "X" && array[1, 1] == "X" && array[2, 2] == "X" ||
                array[0, 2] == "X" && array[1, 1] == "X" && array[2, 0] == "X")
            {
                return 3;
            }
            if (array[0, 0] == "O" && array[0, 1] == "O" && array[0, 2] == "O" ||
                array[1, 0] == "O" && array[1, 1] == "O" && array[1, 2] == "O" ||
                array[2, 0] == "O" && array[2, 1] == "O" && array[2, 2] == "O" ||
                array[0, 0] == "O" && array[1, 0] == "O" && array[2, 0] == "O" ||
                array[0, 1] == "O" && array[1, 1] == "O" && array[2, 1] == "O" ||
                array[0, 2] == "O" && array[1, 2] == "O" && array[2, 2] == "O" ||
                array[0, 0] == "O" && array[1, 1] == "O" && array[2, 2] == "O" ||
                array[0, 2] == "O" && array[1, 1] == "O" && array[2, 0] == "O")
            {
                return 4;
            }

            if (array[0, 0] == " " || array[0, 1] == " " || array[0, 2] == " " ||
                array[1, 0] == " " || array[1, 1] == " " || array[1, 2] == " " ||
                array[2, 0] == " " || array[2, 1] == " " || array[2, 2] == " " ||
                array[0, 0] == " " || array[1, 0] == " " || array[2, 0] == " " ||
                array[0, 1] == " " || array[1, 1] == " " || array[2, 1] == " " ||
                array[0, 2] == " " || array[1, 2] == " " || array[2, 2] == " " ||
                array[0, 0] == " " || array[1, 1] == " " || array[2, 2] == " " ||
                array[0, 2] == " " || array[1, 1] == " " || array[2, 0] == " ")
            {
                return 2;         
            }


            return 1;
        }

        /// <summary>
        /// kjghjh
        /// </summary>
        /// <param name="array"></param>
        static void Print(string[,] array)
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
