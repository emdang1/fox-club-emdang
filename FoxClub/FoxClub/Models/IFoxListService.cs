using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public interface IFoxListService
    {
        List<Fox> ListOfFoxes { get; set; }

        Fox GetFoxByName(string name);
        

    }
}
