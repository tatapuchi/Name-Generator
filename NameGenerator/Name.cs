using System;
using System.Collections.Generic;
using System.Text;

namespace NameGenerator
{
    public static class Name
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

        public static string bolb = "bolb";
        public static string doge = "doge";
        public static string cheems = "cheems";
        public static string cheebs = "cheebs";
        public static string troll = "troll";



    }
}
