using System;
using System.Collections.Generic;
namespace _01Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            int sum = 0;
            string result = "";

            for (int i = 0; i < numbers.Count; i++)
            {
                sum = 0;
                int currNum = numbers[i];
                while (currNum > 0)
                {
                    int lastDigit = currNum % 10;
                    sum += lastDigit;
                    currNum /= 10;
                }

                int index = 0;
                index = sum % input.Length;

                char selectedChar = input[index];
                result += selectedChar;
                input = input.Remove(index, 1);
            }

            Console.WriteLine(result);
        }
    }
}