using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      // int Quantity = 1;
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry),newPastry.GetType());
    }
  }
}
