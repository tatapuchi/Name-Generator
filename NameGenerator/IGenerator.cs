using System;
using System.Collections.Generic;
using System.Text;

namespace NameGenerator
{
    /// <summary>
    /// Top level class regarding the different name Generators
    /// </summary>
    public interface IGenerator
    {
        /// <summary>
        /// Method that generates names
        /// </summary>
        /// <returns>string that contains the name generated</returns>
        public string Generate();

        /// <summary>
        /// Enum containing all the different generator flags
        /// </summary>
        [Flags]
        public enum NameTypes : long
        {
            //Add for other languages
            /// <summary>
            /// No Flags, just simple name generation
            /// </summary>
            None = 0,

            /// <summary>
            /// A number between 0 and 999 will be appended to the name
            /// </summary>
            Numbers = 1,

            /// <summary>
            /// A hashtag will come before the name
            /// </summary>
            Hashtag = 1 << 1
        }

        /// <summary>
        /// Enum containing all the different characters thatt can be used for spaces
        /// </summary>
        public enum SpaceTypes
        {
            /// <summary>
            /// No space character, all letters come right after one another
            /// </summary>
            None,

            /// <summary>
            /// Space character used the space character
            /// </summary>
            Space,

            /// <summary>
            /// Underscore used as the space character
            /// </summary>
            Underscore,

            /// <summary>
            /// Hyphen , AKA dash, used as the space character
            /// </summary>
            Hyphen,

            /// <summary>
            /// A period used as the space character
            /// </summary>
            Period
        }

    }
}
