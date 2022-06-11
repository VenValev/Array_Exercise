using System;
using System.Linq;

namespace _05_Top_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                int br = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        br++;
                    }
                }
                if (br == array.Length - i - 1)
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }
    }
}
