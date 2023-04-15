using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string rock = "rock";
            const string paper = "paper";
            const string scissors = "scissors";

            Console.WriteLine("Welcome to Rock-Paper-Scissors!");
            Console.WriteLine("Enter your move: 'rock', 'paper', or 'scissors'.");

            string playerMove = Console.ReadLine().ToLower();

            if (playerMove == "rock" || playerMove == "r")
            {
                playerMove = rock;
            }
            else if (playerMove == "paper" || playerMove == "p")
            {
                playerMove = paper;
            }
            else if (playerMove == "scissors" || playerMove == "s")
            {
                playerMove = scissors;
            }
            else
            {
                Console.WriteLine("Invalid move. Please try again.");
                return;
            }

            Random random = new Random();
            int computerMoveInt = random.Next(3);
            string computerMove = "";

            switch (computerMoveInt)
            {
                case 0:
                    computerMove = rock;
                    break;
                case 1:
                    computerMove = paper;
                    break;
                case 2:
                    computerMove = scissors;
                    break;
            }

            Console.WriteLine($"You played {playerMove}, and the computer played {computerMove}.");

            if (playerMove == computerMove)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((playerMove == rock && computerMove == scissors) ||
                     (playerMove == paper && computerMove == rock) ||
                     (playerMove == scissors && computerMove == paper))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
