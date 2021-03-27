using System;
using System.Collections.Generic;
using System.Text;
using static NameGenerator.Name;

namespace NameGenerator
{
    public class Generator
    {
        private Random random = new Random();
        private string[] GamerTags;
        private string[] Realistic;
        public NameTypes GeneratorFlags = NameTypes.None;


        public string Generate()
        {

            switch (random.Next(1, 3))
            {
                case 1:
                    return "Butt";
                case 2:
                    return "Yeaz";
                case 3:
                    return "T";
                default:
                    return "Bolb";
            }
        }




    }
}
