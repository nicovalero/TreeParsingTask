using System.Collections.Generic;

namespace TreeParsing.Classes
{
    /// <summary>
    /// Class <c>ListValidator</c> is a helper to validate list values and ensure these meet the requirements.
    /// </summary>
    public static class ListValidator
    {
        /// <summary>
        /// Method <c>GetValidList</c> checks every value of a list to ensure these meet the requirements.
        /// This time, the requirements are: integers greater than zero, and non-repeated.
        /// </summary>
        /// <param name="list"></param>
        /// <returns>A list of integers with non-repeated and greater-than-zero integeres</returns>
        public static List<int> GetValidList(List<int> list)
        {
            List<int> result = new List<int>();
            if (list != null)
            {
                HashSet<int> set = new HashSet<int>();

                foreach(int n in list)
                {
                    if (n > 0 && !set.Contains(n))
                    {
                        result.Add(n);
                        set.Add(n);
                    }
                }
            }
            return result;
        }
    }
}
