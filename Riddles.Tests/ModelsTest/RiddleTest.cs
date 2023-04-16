using Microsoft.VisualStudio.TestTools.UnitTesting;
using Riddles.Models;

namespace Riddle.Tests
{
  [TestClass]
  public class RiddleGameTests
  {

  [TestMethod]
public void GameCreation_NewRiddleGame_Void()
{
  //Arrange 
  RiddleGame game = new RiddleGame();

  //Assert
  Assert.IsNotNull(game);
}
  [TestMethod]
  public void Riddle_GenerateRiddle_ReturnNonEmptyString()
  {
    //Arrange
    RiddleGame game = new RiddleGame();

    //Act
    string riddle = game.GenerateRiddle();

    //Assert 
    Assert.IsFalse(string.IsNullOrEmpty(riddle));
  }

   [TestMethod]
public void CorrectAnswer_UserWins_Void()
{
    //Arrange
    RiddleGame game = new RiddleGame();
    string riddle = game.GenerateRiddle();
    string currentCorrectAnswer = game.GetCorrectAnswer(riddle);
    game.StartGame(currentCorrectAnswer, currentCorrectAnswer);

    //Act
    bool result = game.CheckAnswer(currentCorrectAnswer);

    //Assert
    Assert.IsTrue(result);
    Assert.IsTrue(game.UserHasWon);
    Assert.IsTrue(game.IsGameOver);
}

private string currentCorrectAnswer;
  [TestMethod]
  public void IncorrectAnswer_UserLoses_Void()
  {
    //Arrange
    RiddleGame game = new RiddleGame();
    string riddle = game.GenerateRiddle();
    currentCorrectAnswer = game.GetCorrectAnswer(riddle);
    game.StartGame(currentCorrectAnswer, "wrong answer");

    //Act
    bool result = game.CheckAnswer("wrong answer");

    //Assert
    Assert.IsFalse(result);
    Assert.IsFalse(game.UserHasWon);
    Assert.IsTrue(game.IsGameOver);
  }
  }
}