using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      int Quantity = 1;
      Bread newBread = new Bread(Quantity);
      Assert.AreEqual(typeof(Bread),newBread.GetType());
    }

    [TestMethod]
    public void BreadOrder_CheckBreadOrder_Five()
    {
      int numBreadOrder = 1;
      int orderAmount = 5;

      int result = Bread.BreadOrder(numBreadOrder);

      Assert.AreEqual(orderAmount,result);
    }

    [TestMethod]
    public void BreadOrder_BuyTwoGetOneFree_Ten()
    {
      int numBreadOrder = 2;
      int breadReceive = 3;

      int result = Bread.SpecialDeal(numBreadOrder);

      Assert.AreEqual(breadReceive, result);
    }
  }
}