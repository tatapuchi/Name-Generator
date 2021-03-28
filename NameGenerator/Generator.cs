using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using static NameGenerator.Name;

namespace NameGenerator
{
    public class Generator
    {
        private Random random = new Random();
        public NameTypes GeneratorFlags = NameTypes.None;



        public string Generate()
        {
            return GenerateGamerTag();
        }

        public string GenerateGamerTag() 
        {
            switch(random.Next(0, 4))
            {
                case 0:
                    return Gamerify(Name.bolb);
                case 1:
                    return Gamerify(Name.doge);
                case 2:
                    return Gamerify(Name.cheems);
                case 3:
                    return Gamerify(Name.cheebs);
                case 4:
                    return Gamerify(Name.troll);
                default:
                    return string.Empty;

            }
        }

        public string GenerateRealName()
        {
            switch (random.Next(0, 4))
            {
                case 0:
                    return Gamerify(Name.bolb);
                case 1:
                    return Gamerify(Name.doge);
                case 2:
                    return Gamerify(Name.cheems);
                case 3:
                    return Gamerify(Name.cheebs);
                case 4:
                    return Gamerify(Name.troll);
                default:
                    return string.Empty;

            }
        }

        private string Gamerify(string gamerTag)
        {
            return gamerTag.Replace("o", "0").Replace("l", "1").Replace("e", "3");
        }


    }
}
