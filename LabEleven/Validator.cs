using System;
using System.Collections.Generic;
using System.Text;

namespace LabEleven
{
    public class Validator
    {
        public static bool CheckCategoryChoice(string input, out int category)
        {
            return int.TryParse(input, out category) && category > 0 && category < 5;
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
