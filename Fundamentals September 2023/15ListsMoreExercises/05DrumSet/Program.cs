using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

namespace _05DrumSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> originalValues = new List<int>();
            foreach (int drum in drums)
            {
                originalValues.Add(drum);
            }

            string command;
            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int decrease = int.Parse(command);
                for (int i = 0; i < drums.Count; i++)
                {
                    drums[i] -= decrease;

                    if (drums[i] <= 0)
                    {
                        if (savings >= originalValues[i] * 3)
                        {
                            savings -= originalValues[i] * 3;
                            drums[i] = originalValues[i];
                        }
                        else
                        {
                            drums.RemoveAt(i);
                            originalValues.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
             
            Console.WriteLine(string.Join(" ", drums));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}