﻿using System;
using System.Collections;
using System.IO;
namespace GuessNumberGame
{
  class Program
  {
    static void Main( string[] args )
        {
            GuessNumber guess;
            UI ui = new UI();
            string ans = ui.DrawUI();
            if (ans == "Ja" || ans == "ja")
            {
                guess = new GuessNumber(true);
            }
            else
            {
                guess = new GuessNumber(false);
            }
            guess.PlayGame();
        }
  }

  class UI
  {
    private HighScore scoreList;
    private ArrayList printList;
    private string greeting = "Välkommen till Gissa Numret!";
    private int lDelimLength = 30;
    public UI()
    {
            scoreList = new HighScore();
    }
    public string DrawUI()
    {
            {   //Greeting
                for (int i = 0; i <= lDelimLength; i++)
                    Console.Write("x");
                Console.WriteLine("\n{0}", greeting);
                for (int i = 0; i <= lDelimLength; i++)
                    Console.Write("x");
                Console.WriteLine();
                Console.WriteLine("Här ser du tidigare gissningar:");
            }
            Console.WriteLine();
            string val = "";
            while (!(val == "Ja" || val == "Nej" || val == "ja" || val == "nej"))     //If it is not a valid reply, ask again
            {
                Console.WriteLine("Vill du spela (ja/nej)?");
                val = Console.ReadLine();
                Console.WriteLine();
            }
            return "val";
        }

  }

  class GuessNumber
  {
    private bool runGame;
    private Score gameScore;
    private HighScore scoreList;

    public GuessNumber( bool run )
    {
      runGame = run;
    }
    public void PlayGame()
    {
        int currentNr = 0;
        Random rand = new Random();
        int currentGuess = -1;
        int nrGuesses = 0;
        currentNr = rand.Next(1, 101);
        Console.WriteLine("Guess the number! ");
        while (currentGuess != currentNr)
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
            if (currentGuess > currentNr)
            {
                Console.WriteLine("Too high, try again.");
            }
            else if (currentGuess < currentNr)
            {
                Console.WriteLine("Too low, try again.");
            }
        }
        Console.WriteLine("Grattis! Numret var: {0} och antalet gissningar var: {1}", currentNr, nrGuesses);
        }
  }

    class HighScore
    {

        private FileStream fStream;
        private StreamWriter sWriter;
        private StreamReader sReader;
        private readonly string file = "text.txt";
        public HighScore() { }
        public bool SaveScore(ArrayList score)
        {
            return false;
        }
        public ArrayList PrintScore()
        {
            try
            {
                fStream = new FileStream(file, FileMode.Open);
            }
            catch 
            {

            }
            return new ArrayList();
        }

    }

    class Score
    {
        private string name;
        private int guess;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Guess
        {
            get { return guess; }
            set { guess = value; }
        }
        public Score() { }
    }


}

  







/*

  static class Game
  {
    static ArrayList gameHistory = new ArrayList();
      void TempFunc() { 
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
    static void PlayGame_()
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
*/