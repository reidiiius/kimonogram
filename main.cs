
using System;
using Kimonogram;

  class JinBei {

    static void Main(string[] args) {
      Console.BackgroundColor = ConsoleColor.Black;
      Console.ForegroundColor = ConsoleColor.Green;

      Instrument Chordophone = new Instrument();

      Chordophone.Setable();
      Chordophone.Neptune("eadgbe");

      if (args.Length == 0) {
        Chordophone.ShowMenu();
      }
      else {
        Chordophone.LatticeWork(args);
        Console.WriteLine();
      }

      Console.ResetColor();
    } // Main

  } // JinBei


