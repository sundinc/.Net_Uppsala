using System;

namespace Ovning1_forl1
{
  class Program
  {
    static void Main( string[] args )
    {
      Console.WriteLine("Vad heter du?");
      string name = Console.ReadLine();
      Console.WriteLine("Vad är din favoriträtt?");
      string food = Console.ReadLine();
      Console.WriteLine("Hej," + name + ", kul att du gillar " + food + " det gör jag med");
    }
  }
}
