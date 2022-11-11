using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeParsing.Classes
{
    /// <summary>
    /// Class <c>InputParser</c> is a helper to parse the user input to integers
    /// </summary>
    public static class InputParser
    {
        /// <summary>
        /// Method <c>GetIntegerList</c> is a helper parsing comma-separated values into a List of integers.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>List of integers with valid parsed values</returns>
        public static List<int> GetIntegerList(string input)
        {
            List<int> result = new List<int>();
            if (!string.IsNullOrEmpty(input))
            {
                List<string> inputList = input.Trim().Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();

                foreach (string s in inputList)
                {
                    try
                    {
                        result.Add(int.Parse(s));
                    }
                    catch
                    {

                    }
                }
            }

            return result;
        }
    }
}
