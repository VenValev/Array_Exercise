﻿using System;
using System.Linq;

namespace _08_Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if ((array[i] + array[j]) % number == 0)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");
                    }
                }
            }
        }

    }
}