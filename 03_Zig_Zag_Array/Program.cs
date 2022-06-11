using System;

namespace _03_Zig_Zag_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arrayOne = new int[number];
            int[] arrayTwo = new int[number];

            bool zigZag = false;

            for (int i = 0; i < number; i++)
            {
                string[] somethingStupid = Console.ReadLine().Split(' ');
                if (zigZag == false)
                {
                    arrayOne[i] = int.Parse(somethingStupid[0]);
                    arrayTwo[i] = int.Parse(somethingStupid[1]);
                    zigZag = true;
                }
                else
                {
                    arrayOne[i] = int.Parse(somethingStupid[1]);
                    arrayTwo[i] = int.Parse(somethingStupid[0]);
                    zigZag = false;
                }
            }

            for (int i = 0; i < number; i++)
            {
                Console.Write(arrayOne[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < number; i++)
            {
                Console.Write(arrayTwo[i] + " ");
            }

        }
    }
}
