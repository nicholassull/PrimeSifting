using System;
using System.Collections.Generic;
using PrimeSifter.Models;

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
      Sifter newSifter = new Sifter(userNumber);
      List<int> primeList = newSifter.FindPrimes();
      Console.WriteLine("=========================");
      Console.WriteLine("The primes between 2 and " + userNumber.ToString() + ":");
      foreach (int number in primeList)
      {
        Console.WriteLine(number);
      }
    }

  }
}