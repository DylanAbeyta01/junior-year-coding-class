using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAbeyta_Competency
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            do
            {
                Console.WriteLine("********************************************");
                Console.WriteLine("**1)  Conditionals**");
                Console.WriteLine("**2)  For Loops**");
                Console.WriteLine("**3)  While Loops**");
                Console.WriteLine("**4)  Arrays**");
                Console.WriteLine("**5)  Lists**");
                Console.WriteLine("**-1)  Quit**");
                Console.WriteLine("********************************************");
                input = int.Parse(Console.ReadLine());
                int grade = 0;
                int read = 0;
                int countTo = 0;
                int countBy = 0;

                if (input == 1)
                {
                    Console.WriteLine("What grade are you in?");
                    grade = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is your reading proficiency?");
                    read = int.Parse(Console.ReadLine());

                    if (grade < 6 && grade >= 1)
                    {
                        Console.WriteLine("You are in Elementary School");
                    }
                    else if (grade >= 6 && grade < 9)
                    {
                        Console.WriteLine("You are in Middle School");
                    }
                    else
                    {
                        Console.WriteLine("You are in High School");
                    }                    
                    if (grade <= read)
                    {
                        Console.WriteLine("You read proficiently");                       
                    }
                    else
                    {
                        Console.WriteLine("You dont read proficiently");
                    }
                }
                else if (input == 2)
                {
                    Console.WriteLine("What number would you like to count to?");
                    countTo = int.Parse(Console.ReadLine());
                    Console.WriteLine("What number would you like to count by?");
                    countBy = int.Parse(Console.ReadLine());
                    Console.WriteLine("Count by: " + countBy);
                    Console.WriteLine("Count to: "+ countTo);
                    for (int i = 0; i <= countTo; i+=countBy)
                    {
                        Console.WriteLine(i + ", ");
                    }                           
                }
                else if (input == 3)
                {
                    int num = 0;                   
                    int newSum = 0;
                    Console.WriteLine("Our sum starts at 0. Enter integer value to add to the sum. Enter 0 to stop adding.");
                    do
                    {                      
                            Console.Write("Enter a value: ");
                            num = int.Parse(Console.ReadLine());
                            Console.WriteLine("New sum: " + (newSum + num));
                            newSum = newSum + num;
                            
                    } while (num != 0);
                    Console.WriteLine("Exiting Loop. Our Sum is " + newSum);
                }
                else if (input == 4)
                {
                    int[] array = new int[10];                   
                    int i = 0;
                    Console.WriteLine("You have an array of size 10 and type int. Enter values to populate the array");
                    for (i = 0; i < 10; i++)
                    {
                        array[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine(array[i] + " has successfully been added to the array");
                    }
                    Console.WriteLine("All array values have been added, here they are!");
                    for (i = 0; i < 10; i++)
                    {
                        Console.WriteLine("index[" + i + "] = " + array[i]);
                    }
                }
                else if (input == 5)
                {
                    List<string> list = new List<string>();
                    int i = 0;
                    Console.WriteLine("You have a list of type string. Enter values to add to the list");
                    Console.WriteLine("To stop adding and to print the list, type end");
                    list[i] = Console.ReadLine();
                    for (i = 0; i < list.Count; i++) 
                    {
                        Console.WriteLine(list[i]);
                    }
                }
            } while (input != -1);
            Console.WriteLine("You have quit the program");
        }
    }
}
