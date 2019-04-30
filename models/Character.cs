using System;
using System.ComponentModel.DataAnnotations;

namespace Player.Models
{
    public class Character
    {
        public int CharacterID {get; set;} //pk
        public string CharacterName {get; set;}
        public string FlavorText {get; set;}
        public int Health {get; set;}
        public int Level {get; set;}
        public int Strength {get; set;}
        public int Dexterity {get; set;}
        public int Constitution {get; set;}
        public int Intelligence {get; set;}
        public int Wisdom {get; set;}
        public int Charasma {get; set;}
    }
}