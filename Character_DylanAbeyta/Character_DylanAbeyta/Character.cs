using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_DylanAbeyta
{
    class Character
    {
        public string characterName;
        public int age;
        public string eyeColor;
        public float height;
        public string hairColor;

        public Character(string characterName, int age, string eyeColor, float height, string hairColor)
        {
            this.characterName = characterName;
            this.age = age;
            this.eyeColor = eyeColor;
            this.height = height;
            this.hairColor = hairColor; 
        }
    }
}
