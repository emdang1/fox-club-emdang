using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public string Name { get; set; }
        public string Food { get; set; } = "NONE";
        public string Drink { get; set; } = "NONE";
        public List<string> ListOfTricks { get; set; }

        //public Fox()                              //not needed, since we are not passing whole object anywhere - otherwise it would be necessary
        //{
        //    ListOfTricks = new List<string>();
        //}

        public Fox(string name)
        {
            Name = name;
            ListOfTricks = new List<string>();
        }

        public Fox(string name, string food, string drink)
        {
            Name = name;
            Food = food;
            Drink = drink;
            ListOfTricks = new List<string>();
        }

    }
}
