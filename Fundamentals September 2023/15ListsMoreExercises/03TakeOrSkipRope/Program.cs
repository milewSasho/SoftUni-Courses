using System;
using System.Collections.Generic;
namespace _03TakeOrSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> symbols = new List<char>();
            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                if (char.IsDigit(currChar))
                {
                    int numberAdd = int.Parse(currChar.ToString());
                    numbers.Add(numberAdd);
                }
                else
                {
                    symbols.Add(currChar);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            int symbInd = 0;
            string result = "";
            for (int i = 0; i < takeList.Count && symbInd < symbols.Count; i++)
            {
                int charsTake = takeList[i];
                while (charsTake > 0)
                {
                    result += symbols[symbInd];
                    charsTake--;
                    symbInd++;
                    if (symbInd >= symbols.Count)
                    {
                        break;
                    }
                }

                int charsSkip = skipList[i];
                while (charsSkip > 0)
                {
                    charsSkip--;
                    symbInd++;
                    if (symbInd >= symbols.Count)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}