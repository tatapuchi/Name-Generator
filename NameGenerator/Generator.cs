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
        private string[] GamerTags;
        private string[] Realistic;
        public NameTypes GeneratorFlags = NameTypes.None;



        public string Generate()
        {
            return "Name";
        }

        public string GenerateGamerTag() 
        {
            throw new NotImplementedException(); 
        }

        public string GenerateRealName()
        {
            throw new NotImplementedException();
        }


    }
}
