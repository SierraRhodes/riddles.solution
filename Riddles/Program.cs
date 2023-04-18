using System;
using Riddles.Models;

namespace Riddles.UI
{
class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to the Riddle Game!");
    Console.WriteLine("Press any key to start the game...");
    Console.ReadKey();

    RiddleGame game = new RiddleGame();
    string riddle = game.GenerateRiddle();
    string correctAnswer = game.GetCorrectAnswer(riddle);
    game.StartGame(correctAnswer, "");

    Console.WriteLine("Generating riddle...");
    Console.WriteLine(riddle);

    Console.Write("Enter your answer: ");
    string userAnswer = Console.ReadLine();

    bool result = game.CheckAnswer(userAnswer);

    if(result)
    {
      Console.WriteLine("Congratulation, you won!");
    }
    else
    {
      Console.WriteLine("Sorry, the correct answer is: " + correctAnswer);
    }

    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();

  }
}
}