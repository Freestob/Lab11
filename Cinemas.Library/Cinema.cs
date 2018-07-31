using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemas.Library
{
    public class Cinema
    {
        public string Movie { get; set; }
        public string Genre { get; set; }

        public Cinema(string movie, string genre)
        {
            Movie = movie;
            Genre = genre;
        }

    }
    
}
