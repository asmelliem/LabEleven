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

                var category = MovieService.SetCategoryChoice(int.Parse(Console.ReadLine()));

                Console.WriteLine(MovieService.ReturnMovieList(MovieService.GenerateMovieList(), category));

            } while (MovieService.ContinueProgram());
                      
        }
        
    }
}
