using System;
using Bakery;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTest
  {
    [TestMethod]
    public void Bread_ShoudlCreateABreadObject_Bread()
    {
      Bread loaf = new Bread(3);
      Assert.AreEqual(typeof(Bread), loaf.GetType());
    }
    [TestMethod]
    public void BreadCost_ShoudlReturnACostOf5_Int()
    {
      Bread loaf = new Bread(1);
      loaf.BreadCost();
      Assert.AreEqual(5, loaf.TotalCost);
    }
    [TestMethod]
    public void BreadDiscountAdjust_ShouldReturnACostOf30_int()
    {
      Bread loaf = new Bread(8);
      loaf.BreadCost();
      Assert.AreEqual(30, loaf.TotalCost);
    }
  }
}