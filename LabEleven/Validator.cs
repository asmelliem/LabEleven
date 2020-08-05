using System;
using System.Collections.Generic;
using System.Text;

namespace LabEleven
{
    public class Validator
    {
        public static bool CheckCategoryChoice(string input, out int category)
        {
            return int.TryParse(input, out category);
        }
    }
}
