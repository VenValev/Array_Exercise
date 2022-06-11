using System;
using System.Linq;

namespace _07_Max_Sequence_equal_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int br = 1;
            int numberOfSecuence = 0;
            int maxBr = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {

                if (array[i] == array[i + 1])
                {
                    br++;

                }
                else
                {
                    br = 1;
                }
                if (br > maxBr)
                {
                    maxBr = br;
                    numberOfSecuence = array[i];
                }
            }

            while (maxBr > 0)
            {
                Console.Write($"{numberOfSecuence} ");
                maxBr--;
            }
        }

    }
}
