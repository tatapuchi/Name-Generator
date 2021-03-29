using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using static NameGenerator.Name;

namespace NameGenerator
{
    public class Generator
    {
        private Random random = new Random();
        private Name name = new Name();


        public NameTypes GeneratorFlags = NameTypes.None;



        public string Generate()
        {
            if(random.Next(0, 100) <= 50 ? true : false)
            {
                return GenerateGamerTag();
            }
            else
            {
                return GenerateName();
            }
        }

        public string GenerateGamerTag() 
        {
            return Gamerify(name.GamerTags[random.Next(0, name.GamerTags.Count)]);
        }

        public string GenerateName()
        {
            return name.FirstNames[random.Next(0, name.FirstNames.Count)] + " " + name.LastNames[random.Next(0, name.LastNames.Count)];
        }

        private string Gamerify(string s)
        {
            string gamerTag = s;

            if (random.Next(0, 100) <= 50 ? true : false)
            {
                gamerTag.Replace("o", "0");
            }

            if (random.Next(0, 100) <= 50 ? true : false)
            {
                gamerTag.Replace("l", "1");
            }

            if (random.Next(0, 100) <= 50 ? true : false)
            {
                gamerTag.Replace("e", "3");
            }

            if (random.Next(0, 100) <= 50 ? true : false)
            {
                gamerTag.Replace("S", "$");
                gamerTag.Replace("s", "$");
            }

            if (random.Next(0, 100) <= 50 ? true : false)
            {
                gamerTag += "o_o";
            }

            return gamerTag;

        }


    }
}
