using System.Collections.Generic;

namespace PrimeSifter.Models
{
  public class Sifter
  {
    public int UserNumber { get; set; }
    public List<int> List01 { get; set; }
    public List<int> List02 { get; set; }
    public int Prime { get; set; }

    public Sifter(int userNumber)
    {
      UserNumber = userNumber;
      List01 = CreateList();
      List02 = CreateList();
      Prime = 2;
    }

    public List<int> CreateList()
    {
      List<int> returnList = new List<int> {};
      for (int i = 2; i <= UserNumber; i++)
      {
        returnList.Add(i);
      }
      return returnList;
    }
    public List<int> FindPrimes()
    {
      for (int i = Prime; i <= UserNumber; i++)
      {
        foreach(int number in List01)
        {
          if (number == prime)
          {
            continue;
          }
          else if (number % Prime == 0)
          {
            List02.Remove(number);
          }
        }
        Prime ++;
      }
    }
  }
}