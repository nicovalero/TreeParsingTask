using System.Collections.Generic;

namespace TreeParsing.Classes
{
    public static class ListValidator
    {
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
