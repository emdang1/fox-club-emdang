using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class FoxListService : IFoxListService
    {
        public List<Fox> ListOfFoxes { get; set; }

        public FoxListService()
        {
            ListOfFoxes = new List<Fox>(){
                //new Fox("Fox1", "KEBAB", "COKE"),
                //new Fox("Fox2", "ENCHILADAS", "COKE")
            };
        }

        public Fox GetFoxByName(string name)
        {
            return ListOfFoxes.FirstOrDefault(n => n.Name == name);
        }
    }
}
