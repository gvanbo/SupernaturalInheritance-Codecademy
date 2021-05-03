using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupernaturalInheritance_Codecademy
{
    class Storm
    {
        public string Essence { get; protected set; }
        public bool IsString { get; private set; }
        public string Caster { get; protected set; }

        /// <summary>
        /// Define the storm with the type of the storm, boolean if storm is strong and name of Caster
        /// </summary>
        /// <param Essence="essence"></param>
        /// <param IsString="isString"></param>
        /// <param Caster="caster"></param>
        public Storm (string essence, bool isString, string caster)
        {
            Essence = essence;
            IsString = isString;
            Caster = caster;
        }

        /// <summary>
        /// Announce the Storm summary.
        /// </summary>
        /// <returns>message</returns>
        public string Announce()
        {
            string strength;
            if (IsString == true) strength = "strong";
            else strength = "weak";
            string message = $"{Caster} casts a {strength} {Essence} storm.";
            return message;
        }

    }
}
