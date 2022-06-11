using System;

namespace _02_Comon_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gibirishOne = Console.ReadLine().Split(' ');
            string[] gibirishTwo = Console.ReadLine().Split(' ');
            for (int i = 0; i < gibirishTwo.Length; i++)
            {
                for (int j = 0; j < gibirishOne.Length; j++)
                {
                    if (gibirishOne[j] == gibirishTwo[i])
                    {
                        Console.Write(gibirishTwo[i] + " ");
                    }
                }
            }
        }
    }
}
