using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinemas.Library;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cinema> movieList = new List<Cinema> { };
            movieList.Add(new Cinema("The Bee Movie", "Comedy"));
            movieList.Add(new Cinema("PeeWee's Great Adventure", "Comedy"));
            movieList.Add(new Cinema("Hot Rod", "Comedy"));
            movieList.Add(new Cinema("Lord of the Rings", "Fantasy"));
            movieList.Add(new Cinema("The Thief of Bagdad", "Fantasy"));
            movieList.Add(new Cinema("The Princess Bride", "Fantasy"));
            movieList.Add(new Cinema("50 First Dates", "Rom-Com"));
            movieList.Add(new Cinema("The Notebook", "Rom-Com"));
            movieList.Add(new Cinema("Friday the 13th", "Horror"));
            movieList.Add(new Cinema("The Strangers", "Horror"));

            Console.WriteLine("Which type of movie do you want to see?\n1.\tComedy\n2.\tFantasy\n3.\tRom-Com\n4.\tHorror");
            Console.ReadLine();


        }
    }
}
