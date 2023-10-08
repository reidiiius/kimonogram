
using System;
using Kimonogram;

  class JinBei {

    static void Main(string[] args) {
      Console.ForegroundColor = ConsoleColor.Yellow;

      string tuning = "eadgbe";

      Instrument Chordophone = new Instrument(tuning);

      if (args.Length == 0) {
        Chordophone.ShowMenu();
      }
      else {
        Chordophone.LatticeWork(args);
      }

      Console.ResetColor();
    } // Main

  } // JinBei


