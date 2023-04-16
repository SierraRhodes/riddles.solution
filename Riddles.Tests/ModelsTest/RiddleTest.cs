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
  }
}