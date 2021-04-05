using System;
using System.Collections.Generic;
using System.Text;

namespace NameGenerator.Generators
{
    /// <summary>
    /// A class for the generation of human names.
    /// </summary>
    /// <remarks>Derives from the GeneratorBase abstract class.</remarks>
    public class RealNameGenerator : GeneratorBase
    {

        private List<string> AmericanMaleFirstNames = new List<string>()
            {
                "Liam", "Noah", "Oliver", "William", "Elijah", "James", "Benjamin", "Lucas", "Mason", "Ethan", "Alexander", "Henry", "Jacob",
                "Michael", "Danial", "Logan", "Jackson", "Sebastian", "Jack", "Aiden", "Owen", "Samuel", "Matthew", "Joseph", "Levi", "Mateo",
                "David", "John", "Wyatt", "Carter", "Julian", "Luke", "Grayson", "Isaac", "Jayden", "Theodore", "Gabriel", "Anthony", "Dylon",
                "Leo", "Lincoln", "Jacxon", "Asher", "Christopher", "Andre"
            };

        private List<string> AmericanFemaleFirstNames = new List<string>()
            {
             "Mary", "Patricia", "Linda", "Barbara", "Elizabeth", "Jennifer", "Maria", "Susan", "Margaret", "Dorothy", "Lisa", "Nancy", "Karen", "Betty", "Helen", "Sandra",
             "Donna", "Carol", "Ruth", "Sharon", "Michelle", "Laura", "Sarah", "Kimberly", "Deborah", "Jessica", "Shirley", "Cynthia", "Angela", "Melissa", "Brenda", "Amy",
             "Anna"
            };

        private List<string> AmericanLastNames = new List<string>()
            {
                "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzalez", "Wilson",
                "Anderson", "Thomas", "Taylor", "Moore", "Jackson", "Martin", "Lee", "Perez", "Thompson", "White", "Sanchez", "Harris", "Clark", "Ramirez", "Lewis", "Robinson",
                "Walker", "Young", "Allen", "King", "Wright", "Scott", "Torres", "Nguyen", "Hill", "Flores", "Green", "Adams", "Nelson", "Baker", "Hall", "Rivera", "Campbell",
                "Mitchell", "Carter", "Roberts"
            };

        /// <summary>
        /// This method generates a human name.
        /// It will perform additional operations depending on what generator flags have been set.
        /// </summary>
        /// <returns>A string containing a human name</returns>
        public override string Generate()
        {
            string name;

            if (random.Next(0, 100) <= 50 ? true : false)
            {

                name = AmericanMaleFirstNames[random.Next(0, AmericanMaleFirstNames.Count)] + SpaceCharacter + AmericanLastNames[random.Next(0, AmericanLastNames.Count)];
            }
            else
            {

                name = AmericanFemaleFirstNames[random.Next(0, AmericanFemaleFirstNames.Count)] + SpaceCharacter + AmericanLastNames[random.Next(0, AmericanLastNames.Count)];
            }


            if (GeneratorFlags.HasFlag(NameTypes.Numbers)) { name += (SpaceCharacter + random.Next(0, 999).ToString()); }

            if (GeneratorFlags.HasFlag(NameTypes.Hashtag)) { name = "#" + name; }

            return name;


        }
    }
}
