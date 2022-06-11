using System;
using System.Linq;

namespace _06_Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int indexNumber = -1;

            for (int i = 0; i < array.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    sumLeft += array[j];
                }
                for (int j = i + 1; j < array.Length; j++)
                {
                    sumRight += array[j];
                }
                if (sumRight == sumLeft)
                {
                    indexNumber = i;
                }
            }

            if (indexNumber != -1)
            {
                Console.WriteLine(indexNumber);
            }
            else
            {
                Console.WriteLine("no");
            }
        }

    }
}
