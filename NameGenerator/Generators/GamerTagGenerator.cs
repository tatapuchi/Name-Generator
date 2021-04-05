using System;
using System.Collections.Generic;
using System.Text;

namespace NameGenerator.Generators
{
    /// <summary>
    /// A class for the generation of gamer tags.
    /// </summary>
    /// <remarks>Derives from the GeneratorBase abstract class.</remarks>
    public class GamerTagGenerator : GeneratorBase
    {

        private List<string> GamerTags = new List<string>()
        {
            "bolb", "doge", "cheems", "cheebs", "troll", "lol", "amogus", "red", "sus", "chungus", "big chungus", "impostor", "guagg", "krab", "yo mama", "yharon", "clam"
        };

        /// <summary>
        /// The constructor for the GamerTagGenerator class.
        /// Sets the default space character to an underscore.
        /// </summary>
        public GamerTagGenerator()
        {
            SpaceCharacter = "_";
            GeneratorFlags = NameTypes.None;
        }

        /// <summary>
        /// This method generates a gamertag.
        /// It will perform additional operations depending on what generator flags have been set.
        /// </summary>
        /// <returns>A string containing a gamertag</returns>
        public override string Generate()
        {
            string gamerTag = Randomize(GamerTags[random.Next(0, GamerTags.Count)]);

            gamerTag = gamerTag.Replace(" ", SpaceCharacter);

            if (GeneratorFlags.HasFlag(NameTypes.Numbers)) { gamerTag += (SpaceCharacter + random.Next(0, 999).ToString()); }

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
                gamerTag = gamerTag.Replace("a", "@");
            }

            if (random.Next(0, 100) <= 50 ? true : false)
            {
                gamerTag = gamerTag.Replace("l", "|");
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
