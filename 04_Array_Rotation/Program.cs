using System;

namespace _04_Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotations; i++)
            {
                int lastNumber = items[0];

                for (int j = 0; j < items.Length; j++)
                {

                    if (j + 1 != items.Length)
                    {
                        items[j] = items[j + 1];
                    }
                    else
                    {
                        items[j] = lastNumber;
                    }
                }
            }
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write($"{items[i]} ");
            }
        }
    }
}
