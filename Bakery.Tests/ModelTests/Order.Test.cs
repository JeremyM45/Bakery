using System;
using Bakery;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void Order_CreatesAnOrderObject_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void TotalCostOfOrder_ReturnsTheOrderTotalMessageFor5BreadLoafsAnd0Pastries_String()
    {
      Order newOrder = new Order();
      newOrder.BreadOrder = new Bread(5);
      newOrder.BreadOrder.BreadCost();
      newOrder.PastryOrder = new Pastry(0);
      newOrder.PastryOrder.PastryCost();
      Assert.AreEqual("\nYour order is 5 loaf(s) of bread\nTotal: $20", newOrder.TotalCostOfOrder());
    }
    [TestMethod]
    public void TotalCostOfOrder_ReturnsTheOrderTotalMessageFor0BreadLoafsAnd5Pastries_String()
    {
      Order newOrder = new Order();
      newOrder.BreadOrder = new Bread(0);
      newOrder.BreadOrder.BreadCost();
      newOrder.PastryOrder = new Pastry(5);
      newOrder.PastryOrder.PastryCost();
      Assert.AreEqual("\nYour order is 5 pastry(ies)\nTotal: $9", newOrder.TotalCostOfOrder());
    }
    [TestMethod]
    public void TotalCostOfOrder_ReturnsTheOrderTotalMessageFor5BreadLoafsAnd5Pastries_String()
    {
      Order newOrder = new Order();
      newOrder.BreadOrder = new Bread(5);
      newOrder.BreadOrder.BreadCost();
      newOrder.PastryOrder = new Pastry(5);
      newOrder.PastryOrder.PastryCost();
      Assert.AreEqual("\nYour order is 5 pastry(ies) and 5 loaf(s) of bread\nTotal: $29", newOrder.TotalCostOfOrder());
    }
    
  }
}