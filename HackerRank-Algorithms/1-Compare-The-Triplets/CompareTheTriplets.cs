using System.Collections.Generic;
using System.Linq;

namespace HackerRank_Algorithms._1_Compare_The_Triplets
{
    public static class CompareTheTriplets
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int[] result = { 0, 0 };
            for(int i = 0; i < a.Count; i++)
            {
                if(a[i] > b[i])
                {
                    result[0]++;
                }
                else if (a[i] < b[i])
                {
                    result[1]++;
                }
            }
            return result.ToList<int>();
        }
    }
}
