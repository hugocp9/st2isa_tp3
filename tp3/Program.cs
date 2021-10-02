using System;

namespace tp3
{
    class Program
    {
        static void Main()
        {
            //// count the number of films
            //TP3.MovieCollection.QueryCountAllMovies();
            //Console.WriteLine();

            //// count the number of films with the letter e in his title
            //TP3.MovieCollection.QueryCountAllMoviesWithLetterE();
            //Console.WriteLine();

            //// display the top five higher budget of the list
            //TP3.MovieCollection.QueryHigherBudget();
            //Console.WriteLine();

            //// display the top five lower budget of the list
            //TP3.MovieCollection.QueryLowerBudget();
            //Console.WriteLine();

            //// display the 11 last alphabetic titles
            //TP3.MovieCollection.QueryReverseAlphabetic();
            //Console.WriteLine();

            //TP3.MovieCollection.QueryMoviesBeforeDate();
            //Console.WriteLine();

            //// display the average running time of movies having a vowel as the first letter
            //TP3.MovieCollection.QueryAvgTimeVoyelFirstLetter();
            //Console.WriteLine();

            //// group all films by the number of characters in the title screen and print the count of movies by letter in the film
            //TP3.MovieCollection.QueryGrpByNbChar();
            //Console.WriteLine();

            // calculate average of budget and Box Office of all the films
            TP3.MovieCollection.QueryMeanBudgetBoxOfficeOfAll();
            Console.WriteLine();


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();



        }

        
    }
}
