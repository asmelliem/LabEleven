using System;
using System.Collections.Generic;
using System.Text;

namespace LabEleven
{
    public class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Please select a category (1-4): \n" +
                "1. Animated\n" +
                "2. Drama\n" +
                "3. Horror\n" +
                "4. Scifi");

                var input = Console.ReadLine();
                
                if(Validator.CheckCategoryChoice(input, out var categoryChoice))
                {
                    var movieList = MovieService.ReturnMovieList(MovieService.GenerateMovieList(), categoryChoice);
                    Console.WriteLine("");
                    Console.WriteLine(MovieService.PrintAlphabeticalMovieList(movieList));
                }
                else
                {
                    Console.WriteLine("Looks like there's something wrong with your input.");
                }                

            } while (MovieService.ContinueProgram());

            Console.WriteLine("Goodbye!");
        }        
    }
}
