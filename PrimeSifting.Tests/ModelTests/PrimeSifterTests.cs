using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PrimeSifter.Models;

namespace PrimeSifter.TestTools
{
  [TestClass]
  public class SifterTests
  {
    [TestMethod]
    public void SifterConstructor_CreateInstanceOfSifter_Sifter()
    {
      Sifter newSifter = new Sifter(12);
      Assert.AreEqual(typeof(Sifter), newSifter.GetType());
    }
    [TestMethod]
    public void CreateLists_CreatesLists_IntList()
    {
      Sifter newSifter = new Sifter(4);
      List<int> testList = new List<int> {2, 3, 4};

      List<int> result = newSifter.List01;
      CollectionAssert.AreEqual(testList, result);
    }
    [TestMethod]
    public void FindPrimes_CreateListOfPrimes_IntList()
    {
      Sifter newSifter = new Sifter(32);
      List<int> testList = new List<int> {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31};

      List<int> result = newSifter.FindPrimes();
      CollectionAssert.AreEqual(testList, result);
    }
  }
}