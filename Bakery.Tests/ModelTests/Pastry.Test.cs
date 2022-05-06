using System;
using Bakery;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTest
  {
    [TestMethod]
    public void Pastry_ShoudlCreateABreadObject_Pastry()
    {
      Pastry bakedGoods = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), bakedGoods.GetType());
    }
    [TestMethod]
    public void PastryCost_ShoudlReturnACostOf2_Int()
    {
      Pastry bakedGoods = new Pastry(1);
      bakedGoods.PastryCost();
      Assert.AreEqual(2, bakedGoods.TotalCost);
    }
    [TestMethod]
    public void PastryDiscountAdjust_ShouldReturnACostOf7_int()
    {
      Pastry loaf = new Pastry(4);
      bakedGoods.PastryCost();
      bakedGoods.PastryDiscountAdjust();
      Assert.AreEqual(7, bakedGoods.TotalCost);
    }
  }
}