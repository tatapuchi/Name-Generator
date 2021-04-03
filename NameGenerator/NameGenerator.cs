using System;
using System.Collections.Generic;
using System.Text;
using static NameGenerator.IGenerator;

namespace NameGenerator
{
    /// <summary>
    /// This is the generator subclass for generating real names.
    /// Contains a single method for the generation of a name.
    /// </summary>
    public class NameGenerator : IGenerator
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public NameGenerator()
        {
            Space = " ";
            

        }

        private Random random = new Random();

        /// <summary>
        /// These are enum flags regarding generation settings, such as whether or not to append numbers to the name
        /// </summary>
        public NameTypes GeneratorFlags = NameTypes.None;


        /// <summary>
        /// String that is used instead of a space character, by default it is set to space
        /// </summary>
        public string Space { get; set; }

        /// <summary>
        /// This method generates a random real name, taking generation flags and the chosen space character into account
        /// </summary>
        /// <returns>A string containing a random first and last name, seperated by the chosen space character</returns>
        public string Generate()
        {
            string name;

            if (random.Next(0, 100) <= 50 ? true : false)
            {

                name = Names.AmericanMaleFirstNames[random.Next(0, Names.AmericanMaleFirstNames.Count)] + Space + Names.AmericanLastNames[random.Next(0, Names.AmericanLastNames.Count)];
            }
            else
            {

                name = Names.AmericanFemaleFirstNames[random.Next(0, Names.AmericanFemaleFirstNames.Count)] + Space + Names.AmericanLastNames[random.Next(0, Names.AmericanLastNames.Count)];
            }


            if (GeneratorFlags.HasFlag(NameTypes.Numbers)) { name += (Space + random.Next(0, 999).ToString()); }

            if (GeneratorFlags.HasFlag(NameTypes.Hashtag)) { name = "#" + name; }

            return name;



        }


        private static class Names
        {

                public static List<string> AmericanMaleFirstNames = new List<string>()
            {
                "Liam", "Noah", "Oliver", "William", "Elijah", "James", "Benjamin", "Lucas", "Mason", "Ethan", "Alexander", "Henry", "Jacob",
                "Michael", "Danial", "Logan", "Jackson", "Sebastian", "Jack", "Aiden", "Owen", "Samuel", "Matthew", "Joseph", "Levi", "Mateo",
                "David", "John", "Wyatt", "Carter", "Julian", "Luke", "Grayson", "Isaac", "Jayden", "Theodore", "Gabriel", "Anthony", "Dylon", 
                "Leo", "Lincoln", "Jacxon", "Asher", "Christopher", "Andre"
            };

            public static List<string> AmericanFemaleFirstNames = new List<string>()
            {
             "Mary", "Patricia", "Linda", "Barbara", "Elizabeth", "Jennifer", "Maria", "Susan", "Margaret", "Dorothy", "Lisa", "Nancy", "Karen", "Betty", "Helen", "Sandra",
             "Donna", "Carol", "Ruth", "Sharon", "Michelle", "Laura", "Sarah", "Kimberly", "Deborah", "Jessica", "Shirley", "Cynthia", "Angela", "Melissa", "Brenda", "Amy",
             "Anna"
            };

            public static List<string> AmericanLastNames = new List<string>()
            {
                "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzalez", "Wilson",
                "Anderson", "Thomas", "Taylor", "Moore", "Jackson", "Martin", "Lee", "Perez", "Thompson", "White", "Sanchez", "Harris", "Clark", "Ramirez", "Lewis", "Robinson",
                "Walker", "Young", "Allen", "King", "Wright", "Scott", "Torres", "Nguyen", "Hill", "Flores", "Green", "Adams", "Nelson", "Baker", "Hall", "Rivera", "Campbell", 
                "Mitchell", "Carter", "Roberts"
            };




        }


    }
}
