using System;
namespace GuessANumberProject
{
    internal class GuessANumberProject
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerRandom = randomNumber.Next(1, 11);

            bool isOver = false;
            int attempts = 0;
            int maxAttempts = 5;
            while (!isOver)
            {
                if (attempts >= maxAttempts)
                {
                    isOver = true;
                    DisplayMessage($"Sorry, you have 0 attempts left. The correct number was {computerRandom}.", ConsoleColor.Red);
                    return;
                }
                DisplayMessage($"Guess a number between 1 and 10 (Attempts left: {maxAttempts - attempts}): ", ConsoleColor.Blue);
                string playerInput = Console.ReadLine();
                bool isValid = int.TryParse(playerInput, out int playerNumber);
                if (isValid)
                {
                    attempts++;
                    if (playerNumber == computerRandom)
                    {
                        DisplayMessage($"Congatulations! You guessed the number by your N:{attempts} attempt!", ConsoleColor.Green);
                        break;
                    }
                    else if (playerNumber > computerRandom)
                    {
                        DisplayMessage("Too High", ConsoleColor.Red);
                    }
                    else
                    {
                        DisplayMessage("Too Low", ConsoleColor.Red);
                    }
                }
                else
                {
                    DisplayMessage("Ivalid input.", ConsoleColor.Red);
                }
            }
        }
        static void DisplayMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}