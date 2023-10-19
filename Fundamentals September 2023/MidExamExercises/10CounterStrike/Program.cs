using System;
using System.Diagnostics;

namespace _01CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int indexStrike = int.Parse(Console.ReadLine());
            int radiusStrike = int.Parse(Console.ReadLine());

            int maxLeft = numbers.Count - indexStrike + 1;
            int maxRight = Math.Abs(indexStrike - numbers.Count) - 1;

            if (radiusStrike <= maxLeft && radiusStrike <= maxRight)
            {

                for (int i = indexStrike - radiusStrike; i <= indexStrike; i++)
                {
                    numbers.RemoveAt(i);
                }

                for (int i = indexStrike; i <= indexStrike + radiusStrike - 1; i++)
                {
                    numbers.RemoveAt(i);
                }

                Console.WriteLine(string.Join(" ", numbers));





































































                //int energy = int.Parse(Console.ReadLine());
                //int winsCount = 0;
                //int i = 0;
                //bool endBasttle = false;

                //string command;
                //while ((command = Console.ReadLine()) != "End of battle")
                //{
                //    int distance = int.Parse(command);
                //    i++;

                //    if (energy >= distance)
                //    {
                //        energy -= distance;
                //        if (energy >= 0)
                //        {
                //            winsCount++;
                //            if (i % 3 == 0)
                //            {
                //                energy += winsCount;
                //            }
                //        }
                //    }

                //    else
                //    {
                //        endBasttle = true;
                //        Console.WriteLine($"Not enough energy! Game ends with {winsCount} won battles and {energy} energy");
                //        break;
                //    }
                //}

                //if (!endBasttle)
                //{
                //    Console.WriteLine($"Won battles: {winsCount}. Energy left: {energy}");
                //}
            }
        }
    }
}