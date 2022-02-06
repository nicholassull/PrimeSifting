using System.Collections.Generic;

namespace PrimeSifter.Models
{
  public class Sifter
  {
    public int UserNumber { get; set; }
    public List<int> List01 { get; set; }
    public List<int> List02 { get; set; }

    public Sifter(int userNumber)
    {
      UserNumber = userNumber;
      List01 = CreateLists();
      List02 = CreateLists();
    }

    public List<int> CreateLists()
    {
      List<int> returnList = new List<int> {};
      for (int i = 2; i <= UserNumber; i++)
      {
        returnList.Add(i);
      }
      return returnList;
    }
    // public List<int> FindPrimes()
    // {

    // }
  }
}