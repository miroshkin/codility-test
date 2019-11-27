using System;
using System.Linq;

namespace Codilty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Codility Test Challenge!");

            #region Task Description
                //http://codility.com
                //This is a demo task.
                //Write a function:
                //class Solution { public int solution(int[] A); }
                //that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
                //For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
                //Given A = [1, 2, 3], the function should return 4.
                //Given A = [?1, ?3], the function should return 1.
                //Write an efficient algorithm for the following assumptions:
                //N is an integer within the range [1..100,000];
                //each element of array A is an integer within the range [?1,000,000..1,000,000].
            #endregion

            Solution s = new Solution();
            Console.WriteLine(s.solution(new int[] { 1, 2, 4, 5, 6 }));
            Console.WriteLine(s.solution(new int[] { -1,-3 }));
            Console.WriteLine(s.solution(new int[] { -1,-3, 4 }));
            Console.WriteLine(s.solution(new int[] { 1,2,3 }));
        }

        class Solution
        {
            public int solution(int[] array)
            {
                int result;
                try
                {
                    int min = array.Where(x => x > 0).Min();
                    int max = array.Where(x => x > 0).Max();

                    if (min == max)
                    {
                        return 1;
                    }


                    for (int i = min; i < max; i++)
                    {
                        if (!array.Contains(i))
                        {
                            return i;
                        }

                    }

                    return max + 1;
                }
                catch (Exception)
                {

                    return 1;
                }

                return result;
            }
        }
    }
    
}
