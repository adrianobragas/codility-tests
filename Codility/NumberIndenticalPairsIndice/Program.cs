using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberIndenticalPairsIndice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayN = { 1, 2, 1, 1, 5, 6, 7, 1 };
            Console.WriteLine(solution(arrayN));
        }

        // Return number of elements duplicated in the same arrayN given
        static int solution(int[] arrayN)
        {
            var listDuplicated = new List<int>();
            int[] repetidos;

            for (int i = 0; i < arrayN.Length; i++)
            {
                if (!arrayN.Where(x => x.Equals(arrayN[i])).Count().Equals(1))
                {
                    listDuplicated.Add(arrayN[i]);
                }
            }

            repetidos = arrayN.Where(x => listDuplicated.Contains(x)).ToArray();

            return repetidos.Length;
        } 

    }
}
