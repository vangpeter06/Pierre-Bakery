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
      int Quantity = 1;
      Pastry newPastry = new Pastry(Quantity);
      Assert.AreEqual(typeof(Pastry),newPastry.GetType());
    }

    [TestMethod]
    public void PastryOrder_CheckPastryOrder_Two()
    {
      int numPastryOrder = 1;
      int orderAmount = 2;
      
      int result = Pastry.PastryOrder(numPastryOrder);

      Assert.AreEqual(orderAmount, result);
    }

    [TestMethod]
    public void PastryOrder_BuyThree_Five()
    {
      int numPastryOrder = 3;
      int orderAmount = 5;

      int result = Pastry.PastryOrder(numPastryOrder);

      Assert.AreEqual(orderAmount, result);
    }
  }
}
