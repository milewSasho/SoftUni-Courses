using System;
using System.Collections.Generic;
namespace _02CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double leftTime = 0;
            double rightTime = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int currTime = numbers[i];
                if (currTime == 0)
                {
                    leftTime *= 0.8;
                }
                else
                {
                    leftTime += currTime;
                }
            }

            for (int i = numbers.Count - 1; i >= numbers.Count / 2 + 1; i--)
            {
                int currTime = numbers[i];
                if (currTime == 0)
                {
                    rightTime *= 0.8;
                }
                else
                {
                    rightTime += currTime;
                }
            }

            if (leftTime < rightTime)
            {
                if (leftTime % 1 == 0)
                {
                    Console.WriteLine($"The winner is left with total time: {leftTime}");
                }
                else
                {
                    Console.WriteLine($"The winner is left with total time: {leftTime:f1}");
                }
            }
            else
            {
                if (rightTime % 1 == 0)
                {
                    Console.WriteLine($"The winner is right with total time: {rightTime}");

                }
                else
                {
                    Console.WriteLine($"The winner is right with total time: {rightTime:f1}");
                }
            }
        }
    }
}