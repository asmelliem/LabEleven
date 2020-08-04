using System;
using System.Collections.Generic;
using System.Text;

namespace LabEleven
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please select a category (1-4): \n" +
                "1. Animated\n" +
                "2. Drama\n" +
                "3. Horror\n" +
                "4. Scifi");

            var category = SetCategoryChoice(int.Parse(Console.ReadLine()));

            Console.WriteLine(ReturnMovieList(GenerateMovieList(), category));          
        }

        public static List<Movie> GenerateMovieList()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("Pokemon", "Animated"));
            movies.Add(new Movie("Frozen", "Animated"));
            movies.Add(new Movie("Weathering with You", "Animated"));
            movies.Add(new Movie("Rocketman", "Drama"));
            movies.Add(new Movie("Little Women", "Drama"));
            movies.Add(new Movie("IT", "Horror"));
            movies.Add(new Movie("The Conjuring", "Horror"));
            movies.Add(new Movie("IT", "Horror"));
            movies.Add(new Movie("Star Wars", "Scifi"));
            movies.Add(new Movie("Minority Report", "Scifi"));
            return movies;
        }

        public static StringBuilder ReturnMovieList(List<Movie> movies, string category)
        {
            StringBuilder movieList = new StringBuilder();
            foreach(var movie in movies)
            {
                if (movie.Category == category)
                {
                    movieList.Append($"{movie.Title}\n");
                }
            }

            return movieList;
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
    }
}
