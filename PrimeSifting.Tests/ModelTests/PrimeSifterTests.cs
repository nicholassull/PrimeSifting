using Microsoft.VisualStudio.TestTools.UnitTesting;
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
  }
}