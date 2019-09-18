using System;
using System.Collections;

namespace GuessNumberGame
{
  static class Game
  {
    static ArrayList gameHistory = new ArrayList();
    static void Main( string[] args )
    {
      int choice = -1;
      Console.WriteLine("Welcome to the game!");
      while (choice != 0)
      {
        choice = Menu();
        if (choice == 1)
          PlayGame();
      }
      int counter = 1;
      Console.WriteLine("Game statistics (nr gyuesses): " );
      foreach (int i in gameHistory)
      {
        Console.Write("Game nr {0}: ", counter);
        Console.WriteLine(i + ". ");
        counter++;
      }
      Console.WriteLine();
    }
    static int Menu()
    {
      string val = ".";
      while(!(val == "Y" || val == "N" || val == "y" || val == "n") )     //If it is not a valid reply, ask again
      {
        Console.WriteLine("Play game?: Y/N");
        val = Console.ReadLine();
        Console.WriteLine();
      }
      if (val == "n" || val == "N")
        return 0;
      else
        return 1;
    }
    static void PlayGame()
    {
      int currentNr = 0;
      Random rand = new Random();
      int currentGuess = -1;
      int nrGuesses = 0;
      currentNr = rand.Next(1, 101);
      Console.WriteLine("Guess the number! ");
      while(currentGuess!=currentNr)
      {
        nrGuesses++;
        try
        {
          currentGuess = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
          Console.WriteLine("Invalid number, try again.");
          continue;
        }
        if( currentGuess > currentNr)
        {
          Console.WriteLine("Too high, try again.");
        }
        else if (currentGuess < currentNr)
        {
          Console.WriteLine("Too low, try again.");
        }
      }
      Console.WriteLine("Congratulations! The the number was: {0} and the number of guesses was: {1}", currentNr, nrGuesses);
      gameHistory.Add(nrGuesses);
    }
  }
}
