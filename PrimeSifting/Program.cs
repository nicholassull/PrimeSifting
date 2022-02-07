using System;
using System.Collections.Generic;

namespace PrimeSifter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Prime Sifter!");
      Console.WriteLine("=========================");
      Console.WriteLine("Enter a number between 2 and 100 and I will tell you all the primes found before it.");
      int userNumber = int.Parse(Console.ReadLine());
    }

  }
}