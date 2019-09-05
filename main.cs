
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
        string datum, sargam, diadem;
        DateTime stamp = DateTime.Now;
        diadem = stamp.ToString("yyyyMMddTHHmmss");

        foreach (string signat in args)
        {
          if (Pebbles.digraphs.ContainsKey(signat)) {
            datum = Pebbles.Retrieve(signat);
            sargam = datum.Replace("dd", "__");

            Console.WriteLine();
            Pebbles.HeadStock(signat, sargam, diadem);
          }
          else {
            Console.WriteLine("\n\t{0} ?", signat);
          }
        }
        Console.WriteLine();
      }

      Console.ResetColor();
    } // Main

  } // JinBei


