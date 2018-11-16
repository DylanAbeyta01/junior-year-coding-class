using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Character_DylanAbeyta
{
    class Program
    {
        static int input = 0;
        static string characterName;
        static string h;
        static string hairColor;
        static string name;
        static string n;
        static string eyeColor;
        static string e;
        static int age;
        static int a;
        static float height;
        static float he;


        static void Main(string[] args)
        {
            List<Character> character = new List<Character>();
            do
            {
                Console.WriteLine("1) create a character");
                Console.WriteLine("2) modify a character");
                Console.WriteLine("3) delete a character");
                Console.WriteLine("4) load existing characters");
                Console.WriteLine("5) list characters");
                Console.WriteLine("6) exit");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    character.Add(CreateCharacter());
                    SaveCharacter(character);
                }

                if (input == 2)
                {
                    characterName = ModifyCharacter();
                }

                if (input == 3)
                {
                    DeleteCharacter();
                }

                if (input == 4)
                {
                    LoadCharacter();
                }

                if (input == 5)
                {
                    ListCharacter();
                }   

            } while (input != 6);
            string eyeColor;

            Console.WriteLine("what color is you eye? ");
        }

        static Character CreateCharacter()
        {
            Console.WriteLine("what is your age?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("what is your eye color?");
            eyeColor = Console.ReadLine();
            Console.WriteLine("what is your height?");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("what is your hair color?");
            hairColor = Console.ReadLine();

            return character;
        }

        static void ModifyCharacter(Character character)
        {
            h = hairColor;
            n = name;
            e = eyeColor;
            a = age;
            he = height;

            Console.WriteLine("what Characteristic would you like to modify?");
            Console.WriteLine("h = hairColor");
            Console.WriteLine("n = name");
            Console.WriteLine("e = eyeColor");
            Console.WriteLine("a = age");
            Console.WriteLine("he = height");
            string modify = Console.ReadLine();

            if (modify == "h")
            {
                Console.WriteLine("what is your hair color?");
                hairColor = Console.ReadLine();
            }

            if (modify == "n")
            {
                Console.WriteLine("what is your name?");
                name = Console.ReadLine();
            }

            if (modify == "e")
            {
                Console.WriteLine("what is your eye color?");
                eyeColor = Console.ReadLine();
            }

            if (modify == "a")
            {
                Console.WriteLine("what is your age?");
                age = int.Parse(Console.ReadLine());
            }

            if (modify == "he")
            {
                Console.WriteLine("what is your height?");
                height = float.Parse(Console.ReadLine());
            }




        }

        static void SaveCharacter(Character character)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"character." + characterName + ".txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(character);
            }
        }

        static bool DeleteCharacter(List<Character> characters, string characterName)
        {

        }
        static List<Character> LoadCharacters()
        {
            return ;
        }

        static Character LoadCharacter(string characterName)
        {
            return ;
        }

        static void ListCharacter(List<Character> characters)
        {

        }

    }
}
