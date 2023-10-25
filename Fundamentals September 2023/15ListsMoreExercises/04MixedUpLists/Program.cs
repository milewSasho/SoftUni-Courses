using System;
using System.Collections.Generic;
namespace _04MixedUpLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> list = new List<int>();
            List<int> remain = new List<int>();

            if (firstList.Count > secondList.Count)
            {
                for (int i = firstList.Count - 2; i < firstList.Count; i++)
                {
                    remain.Add(firstList[i]);
                }
                firstList.RemoveRange(firstList.Count - 2, 2);
            }
            else
            {
                for (int i = 0; i < 0 + 2; i++)
                {
                    remain.Add(secondList[i]);
                }
                secondList.RemoveRange(0, 2);
            }

            var sortedRemain = remain.OrderBy(num => num).ToList();

            int firstInd = -1;
            int secondInd = secondList.Count;

            int length = firstList.Count + secondList.Count;
            bool changer = false;
            for (int i = 0; i < length; i++)
            {
                if (!changer)
                {
                    firstInd++;
                    list.Add(firstList[firstInd]);
                }
                else
                {
                    secondInd--;
                    list.Add(secondList[secondInd]);
                }
                changer = !changer;
            }

            List<int> finalList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > sortedRemain[0] && list[i] < sortedRemain[1])
                {
                    finalList.Add(list[i]);
                }
                else
                {
                    continue;
                }
            }

            var sortedFinal = finalList.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(" ", sortedFinal));
        }
    }
}