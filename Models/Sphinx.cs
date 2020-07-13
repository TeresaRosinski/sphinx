using System;

namespace Sphinx 
{
    public class Riddle 
  {
    public string Question { get; set; }
    public string Answer { get; set; }
    public Riddle(string question, string answer)
    {
      Question = question;
      Answer = answer;
    }

    public bool CheckAnswer(string guess) 
    {
      if (guess == Answer)
      {
        Console.WriteLine(guess + " is the correct answer. Congratulations, you may pass.");
      }
      else
      {
        Console.WriteLine(guess + " is incorrect, prepare to be eaten.");
      }
    }
  }  
}