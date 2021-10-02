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

            // Count all the movies made before 1980
            //TP3.MovieCollection.QueryMoviesBeforeDate();
            //Console.WriteLine();

            //// display the average running time of movies having a vowel as the first letter
            //TP3.MovieCollection.QueryAvgTimeVoyelFirstLetter();
            //Console.WriteLine();

            //// group all films by the number of characters in the title screen and print the count of movies by letter in the film
            //TP3.MovieCollection.QueryGrpByNbChar();
            //Console.WriteLine();

            //// calculate the mean of all Budget / Box Office of every movie ever
            //TP3.MovieCollection.QueryBBMeanOfAll();
            //Console.WriteLine();

            //// Calculate the mean of all Budget / Box Office of every movie grouped by yearly release date
            //TP3.MovieCollection.QueryGroupedByBBMean();
            //Console.WriteLine();

            //// Print all movies with the letter H or W in the title, but not the letter I or T
            //TP3.MovieCollection.QueryAllMoviesWithCharCondition();
            //Console.WriteLine();

            // Group all movies made before 1997 by their director, ...
            TP3.MovieCollection.QueryGroupByDirector();
            Console.WriteLine();




            Console.WriteLine("Press any key to exit");
            Console.ReadKey();



        }

        
    }
}
