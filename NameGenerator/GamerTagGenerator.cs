using System;
using System.Collections.Generic;
using System.Text;
using static NameGenerator.IGenerator;

namespace NameGenerator
{
    /// <summary>
    /// Class for generating gamer tags
    /// </summary>
    public class GamerTagGenerator : IGenerator
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public GamerTagGenerator()
        {
            Space = "_";
        }

        private Random random = new Random();

        /// <summary>
        /// Settings regarding generated names
        /// </summary>
        public NameTypes GeneratorFlags = NameTypes.Numbers;

        /// <summary>
        /// What character is to be used as a space
        /// </summary>
        public string Space { get; set; }

        private List<string> GamerTags = new List<string>()
        {
            "bolb", "doge", "cheems", "cheebs", "troll", "lol", "amogus", "red", "sus", "chungus", "big chungus", "impostor", "guagg", "krab", "yo mama", "yharon"
        };


        /// <summary>
        /// Method that generates a gamertag, taking into account generation flags such as whether to add numbers or not
        /// </summary>
        /// <returns>A string containing a gamertag</returns>
        public string Generate()
        {
            string gamerTag = Randomize(GamerTags[random.Next(0, GamerTags.Count)]);

            gamerTag = gamerTag.Replace(" ", Space);

            if (GeneratorFlags.HasFlag(NameTypes.Numbers)) { gamerTag += (Space + random.Next(0, 999).ToString()); }

            if (GeneratorFlags.HasFlag(NameTypes.Hashtag)) { gamerTag = "#" + gamerTag; }

            return gamerTag;
        }


        private string Randomize(string s)
        {
            string gamerTag = s;

            if (random.Next(0, 100) <= 50 ? true : false)
            {
                gamerTag = gamerTag.Replace("o", "0");
            }

            if (random.Next(0, 100) <= 50 ? true : false)
            {
                gamerTag = gamerTag.Replace("l", "1");
            }

            if (random.Next(0, 100) <= 50 ? true : false)
            {
                gamerTag = gamerTag.Replace("e", "3");
            }

            if (random.Next(0, 100) <= 50 ? true : false)
            {
                gamerTag = gamerTag.Replace("S", "$");
                gamerTag = gamerTag.Replace("s", "$");
            }

            return gamerTag;

        }

    }
}
