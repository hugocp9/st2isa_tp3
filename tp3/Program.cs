using System;

namespace tp3
{
    class Program
    {
        static void Main()
        {
            // count the number of films
            TP3.MovieCollection.QueryCountAllMovies();
            Console.WriteLine();

            // count the number of films with the letter e in his title
            TP3.MovieCollection.QueryCountAllMoviesWithLetterE();
            Console.WriteLine();

            // display the top five higher budget of the list
            TP3.MovieCollection.QueryHigherBudget();
            Console.WriteLine();

            // display the top five lower budget of the list
            TP3.MovieCollection.QueryLowerBudget();
            Console.WriteLine();

            // display the 11 last alphabetic titles
            TP3.MovieCollection.QueryReverseAlphabetic();
            Console.WriteLine();

            // TP3.MovieCollection.QueryMoviesBeforeDate();
            // Console.WriteLine();

            TP3.MovieCollection.QueryAvgTimeVoyelFirstLetter();
            Console.WriteLine();

            TP3.MovieCollection.QueryGrpByNbChar();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();



        }

        
    }
}
