using System;
using System.Linq;

namespace _10_Ladybug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int[] ladybugIndex = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();
            int[] field = new int[sizeOfField];

            for (int i = 0; i < sizeOfField; i++)
            {
                if (ladybugIndex.Contains(i))
                {
                    field[i] = 1;
                }
            }

            /*string instructions = Console.ReadLine();
            while(instructions != "end")
            {
                instructions = Console.ReadLine();

            }*/
            string instructions;
            while ((instructions = Console.ReadLine()) != "end")
            {
                string[] instructionsArg = instructions.
                    Split(' ', StringSplitOptions.RemoveEmptyEntries).
                    ToArray();
                int initialIndex = int.Parse(instructionsArg[0]);
                string direction = instructionsArg[1];
                int flyLenght = int.Parse(instructionsArg[2]);

                if (initialIndex < 0 || initialIndex >= field.Length)
                {
                    continue;
                }

                if (field[initialIndex] == 0)
                {
                    continue;
                }

                field[initialIndex] = 0;

                int nextIndex = initialIndex;

                while (true)
                {
                    if (direction == "right")
                    {
                        nextIndex += flyLenght;
                    }
                    else if (direction == "left")
                    {
                        nextIndex -= flyLenght;
                    }

                    if (nextIndex < 0 || nextIndex >= field.Length)
                    {
                        break;
                    }

                    if (field[nextIndex] == 0)
                    {
                        break;
                    }

                }

                if (nextIndex >= 0 && nextIndex < field.Length)
                {
                    field[nextIndex] = 1;
                }

            }

            Console.WriteLine(String.Join(" ", field));
        }

    }
}
