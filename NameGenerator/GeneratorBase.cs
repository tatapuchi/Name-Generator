using System;
using System.Collections.Generic;
using System.Text;

namespace NameGenerator
{
    /// <summary>
    /// An abstract class that serves as the base for all generators.
    /// </summary>
    public abstract class GeneratorBase
    {
        /// <summary>
        /// An instance of the Random class used to randomize the generation.
        /// </summary>
        protected Random random = new Random();

        /// <summary>
        /// The method for generating names or gamertags.
        /// </summary>
        /// <returns>A string containing the generated name.</returns>
        public abstract string Generate();

        private NameTypes _generatorFlags = NameTypes.None;
        /// <summary>
        /// An enum property that defines the generator flags, which perform additional operations on the string once it has been generated.
        /// By default there are no generator flags.
        /// </summary>
        /// <remarks>
        /// Possible generator flags could be Numbers or Hashtag.
        /// </remarks>
        /// <example>
        /// <code>
        /// Generator MyGenerator = new Generator();
        /// MyGenerator.GeneratorFlags |= NameTypes.Number;
        /// MyGenerator.Generate();
        /// </code>
        /// </example>
        public NameTypes GeneratorFlags { get => _generatorFlags; set => _generatorFlags = value; }

        private string _spaceCharacter = " ";
        /// <summary>
        /// A string property that defines what character to be used in place of a space.
        /// By default, the space character is a space.
        /// </summary>
        /// <remarks>
        /// Possible space characters could be an underscore, a dash, a space, nothing at all, etc.
        /// </remarks>
        /// <example>
        /// <code>
        /// Generator MyGenerator = new Generator();
        /// MyGenerator.SpaceCharacter = "_"
        /// MyGenerator.Generate();
        /// </code>
        /// </example>
        public string SpaceCharacter { get => _spaceCharacter; set => _spaceCharacter = value; }






        /// <summary>
        /// Enum containing all the different generator flags.
        /// </summary>
        [Flags]
        public enum NameTypes : long
        {
            //Add for other languages
            /// <summary>
            /// No Flags, just plain and simple name generation.
            /// </summary>
            None = 0,

            /// <summary>
            /// A number between 0 and 999 will be appended to the name.
            /// </summary>
            Numbers = 1,

            /// <summary>
            /// A hashtag will come before the name.
            /// </summary>
            Hashtag = 1 << 1
        }

    }
}
