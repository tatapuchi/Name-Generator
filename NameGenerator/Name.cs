using System;
using System.Collections.Generic;
using System.Text;

namespace NameGenerator
{
    public class Name
    {
        [Flags]
        public enum NameTypes : long
        {
            None = 0,
            GamerTags = 1,
            Realistic = 1 << 1,
            Gibberish = 1 << 2,
            Numbers = 1 << 3,
            SpecialCharacters = 1 << 4,
            OtherLanguages = 1 << 5
        }
        //o -> 0
        //e -> 3
        //i -> !
        //All lowercase


        public List<string> GamerTags = new List<string>() 
        { 
            "bolb", "doge", "cheems", "cheebs", "troll", "lol"
        };


        public List<string> FirstNames = new List<string>() 
        {
            "Jack", "John", "Aiden", "Rebecca", "Josh", "Anais", "Vibhor", "Danial", "Ulises", "Oliver", "David", "Diego" 
        };


        public List<string> LastNames = new List<string>() {
            "Griffin", "Brown", "Singh", "Deyes", "Holst", "Müller", "Chang", "Sanchez" 
        };



    }
}
