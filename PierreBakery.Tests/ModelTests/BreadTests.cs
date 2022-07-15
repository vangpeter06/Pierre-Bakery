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
      // int quantity = 1;
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread),newBread.GetType());
    }
  }
}