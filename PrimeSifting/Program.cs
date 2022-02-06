using System;
using System.Collections.Generic;

namespace PrimeSifter
{
  public class Program
  {
    public static void Main()
    {
      List<int> NumberList01 = new List<int> {2, 3, 4, 5, 6, 7, 8, 9, 10};
      List<int> NumberList02 = new List<int> {2, 3, 4, 5, 6, 7, 8, 9, 10};
      Console.WriteLine("Origonal List:");
      NumberList01.ForEach(Console.WriteLine);

      int prime = 2;
      foreach(int number in NumberList01)
      {
        if (number == prime)
        {
          continue;
        }
        else if (number % prime == 0)
        {
          NumberList02.Remove(number);
        }
      }
      NumberList02.ForEach(Console.WriteLine);
    }

  }
}