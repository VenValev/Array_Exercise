using System;

namespace _01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] passangers = new int[number];
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                passangers[i] = int.Parse(Console.ReadLine());
                sum += passangers[i];
            }
            for (int i = 0; i < number; i++)
            {
                Console.Write($"{passangers[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
