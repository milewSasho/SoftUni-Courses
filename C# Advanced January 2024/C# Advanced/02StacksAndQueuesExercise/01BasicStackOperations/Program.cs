using System;
using System.Linq;
using System.Collections.Generic;
namespace _01BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int elementsPushCount = input[0];
            int elementsPopCount = input[1];
            int elementSearch = input[2];

            int[] numebrsPush = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new(numebrsPush);

            for (int i = 0; i < elementsPopCount; i++)
            {
                numbers.Pop();
            }

            if (numbers.Any())
            {
                if (numbers.Contains(elementSearch))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numbers.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}