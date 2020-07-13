using System;

namespace Sphinx 
{
  public class Program
  {
    public static void Main()
    {
      Riddle riddle1 = new Riddle("Which creature walks on four legs in the morning, two legs at midday, and three legs in the evening?", "A Human");
      Riddle riddle2 = new Riddle("A box without doors, hinges, or a lid, but inside treausre is hid", "An Egg");
      Riddle riddle3 = new Riddle("30 white horses on a red hill, first the champ, then they stamp then they stand still", "Teeth");


      Console.WriteLine("Guess the answer to the riddle to avoid being eaten!")
    }
  }
}