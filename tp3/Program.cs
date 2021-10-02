using System;

namespace tp3
{
    class Program
    {
        static void Main()
        {
            TP3.MovieCollection.QueryCountAllMovies();
            Console.WriteLine();
            TP3.MovieCollection.QueryCountAllMoviesWithLetterE();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();



        }

        
    }
}
