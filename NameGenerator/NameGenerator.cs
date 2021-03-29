using System;
using System.Collections.Generic;
using System.Text;
using static NameGenerator.IGenerator;

namespace NameGenerator
{
    /// <summary>
    /// Class for generating real names
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
        /// Settings regarding generated names
        /// </summary>
        public NameTypes GeneratorFlags = NameTypes.None;

        /// <summary>
        /// What character is to be used as a space
        /// </summary>
        public string Space { get; set; }

        private List<string> FirstNames = new List<string>()
        {
            "Jack", "John", "Aiden", "Rebecca", "Josh", "Anais", "Vibhor", "Danial", "Ulises", "Oliver", "David", "Diego", "Joaquin",
            "Joe", "Albert", "Philipp", "Josh", "Jayden", "Will", "Tyrone", "Akansh", "Stephanie", "Hollis", "Valeria", "Andre", "Luca"
        };


        private List<string> LastNames = new List<string>() {
            "Griffin", "Brown", "Singh", "Deyes", "Holst", "Müller", "Chang", "Sanchez", "Smith", "Italiano", "Foster", "Simpson", "Gupta", "Bachmann",
            "Arroyo", "Cuida", "Kosma"
        };


        /// <summary>
        /// Method that generates a real name, taking into account generation flags such as whether to add numbers or not
        /// </summary>
        /// <returns>A string containing a first and last name</returns>
        public string Generate()
        {
            string name = FirstNames[random.Next(0, FirstNames.Count)] + Space + LastNames[random.Next(0, LastNames.Count)];

            if (GeneratorFlags.HasFlag(NameTypes.Numbers)) { name += (Space + random.Next(0, 999).ToString()); }

            if (GeneratorFlags.HasFlag(NameTypes.Hashtag)) { name = "#" + name; }

            return name;
        }
    }
}
