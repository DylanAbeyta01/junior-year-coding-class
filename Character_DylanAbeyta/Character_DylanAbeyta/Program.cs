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
        static List<Character> character = new List<Character>();

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("*********************************");
                Console.WriteLine("1) create a character");
                Console.WriteLine("2) modify a character");
                Console.WriteLine("3) delete a character");
                Console.WriteLine("4) load existing characters");
                Console.WriteLine("5) list characters");
                Console.WriteLine("6) exit");
                Console.WriteLine("*********************************");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    character.Add(CreateCharacter());
                }

                if (input == 2)
                {
                    Console.WriteLine("What Character Would you like to modify?");
                    string filename = Console.ReadLine();
                    character.Add(LoadCharacter(filename));
                    for (int i = 0; i < character.Count; i++)
                    {
                        if (character[i].characterName == filename)
                        {
                            ModifyCharacter(character[i]);
                            break;
                        }
                        else
                            Console.WriteLine("file not found");
                    }
                }

                if (input == 3)
                {
                    if (DeleteCharacter(character, characterName) == true)
                    {
                        Console.WriteLine(characterName + "was deleted");
                    }

                    else
                    {
                        Console.WriteLine(characterName + "does not exist, therefore was not removed");
                    }
                }

                if (input == 4)
                {
                    Console.WriteLine("what character would you like to load?");
                    string uname = Console.ReadLine();
                    character.Add(LoadCharacter(uname));
                }

                if (input == 5)
                {                  
                    ListCharacter(character);
                }

            } while (input != 6);
            Console.ReadKey();
        }

        static Character CreateCharacter()
        {
            Console.WriteLine("what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("what is your age?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("what is your eye color?");
            eyeColor = Console.ReadLine();
            Console.WriteLine("what is your height?");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("what is your hair color?");
            hairColor = Console.ReadLine();
            Character character = new Character(name, age, eyeColor, height, hairColor);
            SaveCharacter(character);
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
            Console.WriteLine("e = eyeColor");
            Console.WriteLine("a = age");
            Console.WriteLine("he = height");
            string modify = Console.ReadLine();

            if (modify == "h")
            {
                Console.WriteLine("what is your hair color?");
                hairColor = Console.ReadLine();
                character.hairColor = hairColor;
            }         

            if (modify == "e")
            {
                Console.WriteLine("what is your eye color?");
                eyeColor = Console.ReadLine();
                character.eyeColor = eyeColor;
            }

            if (modify == "a")
            {
                Console.WriteLine("what is your age?");
                age = int.Parse(Console.ReadLine());
                character.age = age;
            }
     
            if (modify == "he")
            {
                Console.WriteLine("what is your height?");
                height = float.Parse(Console.ReadLine());
                character.height = height;
            }
            SaveCharacter(character);
        }

        static void SaveCharacter(Character character)
        {
            Console.WriteLine("what character would you like to save?");
            string characterName = Console.ReadLine();
            string path = AppDomain.CurrentDomain.BaseDirectory + @"character." + character.characterName + ".txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(character.characterName + "\r\n" + character.age + "\r\n" + character.eyeColor + "\r\n" + character.height + "\r\n" + character.eyeColor);
            }
        }

        static bool DeleteCharacter(List<Character> characters, string characterName)
        {
            bool Deleted = false;
            string delete;
            Console.WriteLine("what character would you like to delete?");
            delete = Console.ReadLine();

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"character." + delete + ".txt"))
            {
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"character." + delete + ".txt");
                Deleted = true;
            }
            else
            {
                Deleted = false;
            }

            return Deleted;
        }

        static Character LoadCharacter(string characterName)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"character." + characterName + ".txt";
            string line;
            List<String> file = new List<String>();
            using (StreamReader sr = new StreamReader(path))
            {              
                while ((line = sr.ReadLine()) != null)
                {
                    file.Add(line);
                }                           
            }
            Character NCharacter = new Character(file[0], int.Parse(file[1]), file[2], float.Parse(file[3]), file[4]);
            return NCharacter;
        }

        static void ListCharacter(List<Character> character)
        {                     
            for (int i = 0; i < character.Count; i++)
            {
                Console.WriteLine(character[i].characterName);
                Console.WriteLine(character[i].age);
                Console.WriteLine(character[i].eyeColor);
                Console.WriteLine(character[i].height);
                Console.WriteLine(character[i].hairColor);
            }                                  
        }

    }
}
