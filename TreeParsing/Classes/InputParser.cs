using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeParsing.Classes
{
    public static class InputParser
    {
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
