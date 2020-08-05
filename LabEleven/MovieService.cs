using System;
using System.Collections.Generic;
using System.Text;

namespace LabEleven
{
    public class MovieService
    {
        public static List<Movie> GenerateMovieList()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("Pokemon", "Animated"));
            movies.Add(new Movie("Frozen", "Animated"));
            movies.Add(new Movie("Weathering with You", "Animated"));
            movies.Add(new Movie("Rocketman", "Drama"));
            movies.Add(new Movie("Little Women", "Drama"));
            movies.Add(new Movie("The Grudge", "Horror"));
            movies.Add(new Movie("The Conjuring", "Horror"));
            movies.Add(new Movie("IT", "Horror"));
            movies.Add(new Movie("Star Wars", "Scifi"));
            movies.Add(new Movie("Minority Report", "Scifi"));
            return movies;
        }

        public static List<string> ReturnMovieList(List<Movie> movies, int categoryChoice)
        {
            List<string> movieList = new List<string>();
            var category = SetCategoryChoice(categoryChoice);

            foreach (var movie in movies)
            {
                if (movie.Category == category)
                {
                    movieList.Add(movie.Title);
                }
            }
            return movieList;
        }        

        public static StringBuilder PrintAlphabeticalMovieList(List<string> movieList)
        {
            StringBuilder sortedMovies = new StringBuilder();
            movieList.Sort();
            foreach(var movie in movieList)
            {
                sortedMovies.Append($"{movie}\n");
            }
            return sortedMovies;
        }

        public static string SetCategoryChoice(int input)
        {
            if (input == 1)
            {
                return "Animated";
            }
            else if (input == 2)
            {
                return "Drama";
            }
            else if (input == 3)
            {
                return "Horror";
            }
            else
            {
                return "Scifi";
            }
        }

        public static bool ContinueProgram()
        {
            while (true)
            {
                Console.WriteLine("Would you like to continue? (y/n)");
                var input = Console.ReadLine().ToUpper();

                if (input == "Y")
                {
                    return true;
                }
                else if (input == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("You didn't enter a 'Y' or 'N'");
                }
            }
        }
    }
}
