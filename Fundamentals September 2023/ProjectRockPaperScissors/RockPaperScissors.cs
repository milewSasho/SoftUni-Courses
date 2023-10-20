using System;
namespace RockPaperScissorsProject
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            string playAgain = "";
            int playerWins = 0;
            int computerWins = 0;
            int drawsCount = 0;
            int playerInRow = 0;
            int computerInRow = 0;

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = "";

            while (playAgain != "no")
            {
                const string Rock = "Rock";
                const string Paper = "Paper";
                const string Scissors = "Scissors";
                Console.Clear();
                DisplayMessage("Choose [r]ock, [p]aper or [s]cissors: ", ConsoleColor.Blue);
                string playerMove = Console.ReadLine();

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = Scissors;
                }
                else
                {
                    DisplayMessage("Invalid input. Try again...", ConsoleColor.Red);
                    continue;
                }

                switch (computerRandomNumber)
                {
                    case 1: computerMove = Rock; break;
                    case 2: computerMove = Paper; break;
                    case 3: computerMove = Scissors; break;
                }

                DisplayMessage($"The computer chose {computerMove}.", ConsoleColor.Blue);

                if ((playerMove == Rock && computerMove == Scissors) ||
                    (playerMove == Paper && computerMove == Rock) ||
                    (playerMove == Scissors && computerMove == Paper))
                {
                    playerWins++;
                    playerInRow++;
                    computerInRow = 0;
                    DisplayMessage("You win.", ConsoleColor.Green);
                }
                else if ((playerMove == Scissors && computerMove == Rock) ||
                    (playerMove == Rock && computerMove == Paper) ||
                    (playerMove == Paper && computerMove == Scissors))
                {
                    computerWins++;
                    computerInRow++;
                    playerInRow = 0;
                    DisplayMessage("You lose.", ConsoleColor.Red);
                }
                else
                {
                    drawsCount++;
                    playerInRow = 0;
                    computerInRow = 0;
                    DisplayMessage("This game was a draw.", ConsoleColor.Blue);
                }

                if (playerInRow == 3)
                {
                    DisplayMessage($"Great! You won {playerInRow} games in row!", ConsoleColor.Green);
                    playerInRow = 0;
                }
                else if (computerInRow == 3)
                {
                    DisplayMessage($"Oh no! You lost {computerInRow} games in row", ConsoleColor.Red);
                    computerInRow = 0;
                }

                DisplayMessage("Type {yes} to play again or {no} to quit: ", ConsoleColor.Blue);
                playAgain = Console.ReadLine();

                while (playAgain != "yes" && playAgain != "no")
                {
                    DisplayMessage("Invalid input! Type {yes} ot {no}: ", ConsoleColor.Red);
                    playAgain = Console.ReadLine();
                    Console.Clear();
                }
                if (playAgain == "no")
                {
                    DisplayMessage($"Your wins count is: {playerWins}", ConsoleColor.Green);
                    DisplayMessage($"Your lose count is: {computerWins}", ConsoleColor.Red);
                    DisplayMessage($"The draw games count is: {drawsCount}", ConsoleColor.Blue);
                    break;
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