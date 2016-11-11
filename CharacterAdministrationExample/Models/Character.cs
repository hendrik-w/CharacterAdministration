using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterAdministrationExample.Models
{
    public class Character
    {
        public String Name;

        /// <summary>
        /// Creates the specified name and add it to the GlobalVariables.
        /// </summary>
        /// <param name="name">The name.</param>
        public static void Create(String name)
        {
            Character character = new Character();
            character.Name = name;

            if(GlobalVariables.Characters == null)
                GlobalVariables.Characters = new List<Character>();

            GlobalVariables.Characters.Add(character);
        }

        /// <summary>
        /// Gets all characters in GlobalVariables.
        /// </summary>
        /// <returns></returns>
        public static List<Character> GetAll()
        {
            if (GlobalVariables.Characters == null)
                GlobalVariables.Characters = new List<Character>();

            return GlobalVariables.Characters; 
        } 
    }
}