using System;
namespace _02BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startPoints = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            if (startPoints <= 100)
            {
                bonus = 5;
            }
            else if (startPoints > 100 && startPoints <= 1000)
            {
                bonus = startPoints * 0.2;
            }
            else
            {
                bonus = startPoints * 0.1;
            }
            if (startPoints % 2 == 0)
            {
                bonus = bonus + 1;
            }
            if (startPoints % 10 == 5)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(startPoints + bonus);
        }
    }
}