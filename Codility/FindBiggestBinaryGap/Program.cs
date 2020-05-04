using System;

namespace FindBiggestBinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(1041));
        }

        // Return biggest Gap binary
        static int solution(int number)
        {
            char token = '1';
            string binaryNumber;
            string biggestGap;
            
            if (number <= 0 )
            {
                return 0;
            }

            binaryNumber = Convert.ToString(number, 2);
            string[] values = binaryNumber.Split(token);

            if (values.Length > 2)
            {
                Array.Sort(values);
                Array.Reverse(values);
                biggestGap = values[0];
            }
            else
            {
                return 0;
            }
            return biggestGap.Length;
        }
    }
}
