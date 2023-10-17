using System;
using System.Collections.Generic;
namespace _08AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();
                string[] arguments = command.Split();

                switch (arguments[0])
                {
                    case "Merge":
                        int startIndex = int.Parse(arguments[1]);
                        int endIndex = int.Parse(arguments[2]);
                        if (!IsIndexValid(inputList, startIndex, endIndex))
                        {
                            break;
                        }
                        MergeElements(inputList, startIndex, endIndex);
                        break;
                    case "Divide":
                        int index = int.Parse(arguments[1]);
                        int partitions = int.Parse(arguments[2]);
                        if (!IsIndexValid(inputList, index, partitions))
                        {
                            break;
                        }
                        DivideElement(inputList, index, partitions);
                        break;
                }
            }
        }

        static void DivideElement(List<string> inputList, int index, int partitions)
        {

        }

        static string MergeElements(List<string> inputList, int startIndex, int endIndex)
        {
            string result = string.Concat(inputList.GetRange(startIndex, endIndex - startIndex + 1));
            return result;
        }

        static bool IsIndexValid(List<string> inputList, int startIndex, int endIndex)
        {
            return (startIndex >= 0 && startIndex <= inputList.Count - 1) &&
                    (endIndex >= 0 && endIndex <= inputList.Count - 1);
        }
    }
}