
using System;
using Kimonogram;

  class JinBei {

    static void Main(string[] args) {
      Console.BackgroundColor = ConsoleColor.Black;
      Console.ForegroundColor = ConsoleColor.Green;

      Alluvium Pebbles = new Alluvium();

      Pebbles.Setable();

      if (args.Length == 0) {
        Pebbles.ShowMenu();
      }
      else {
        Pebbles.LatticeWork(args);
        Console.WriteLine();
      }

      Console.ResetColor();
    } // Main

  } // JinBei


