using System;

namespace SmallEstInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -1, -72, 3 };
            Console.WriteLine(solution(numbers));
        }

        static int solution(int[] A)
        {
            int smallInteger = 1;
            
            Array.Sort(A);
            foreach (int i in A)
            {
                if (i == smallInteger)
                {
                    smallInteger++;
                }
            }
            return smallInteger;
        }
    }
}
