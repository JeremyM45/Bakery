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
      Asster.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void OrderTotal_ReturnsTheOrderTotalMessageFor5BreadLoafsAnd0Pastries_String()
    {
      Order newOrder = newOrder();
      newOrder.BreadOrder = new Bread(5);
      newOrder.PastryOrder = new Pastry(0);
      Assert.AreEqual("Your order is 5 loaf(s) of bread\nTotal: $20", newOrder.OrderTotal());
    }
    [TestMethod]
    public void OrderTotal_ReturnsTheOrderTotalMessageFor0BreadLoafsAnd5Pastries_String()
    {
      Order newOrder = newOrder();
      newOrder.BreadOrder = new Bread(0);
      newOrder.PastryOrder = new Pastry(5);
      Assert.AreEqual("Your order is 5 pastry(ies)\nTotal: $9", newOrder.OrderTotal());
    }
    [TestMethod]
    public void OrderTotal_ReturnsTheOrderTotalMessageFor5BreadLoafsAnd5Pastries_String()
    {
      Order newOrder = newOrder();
      newOrder.BreadOrder = new Bread(5);
      newOrder.PastryOrder = new Pastry(5);
      Assert.AreEqual("Your order is 5 pastry(ies) and 5 loaf(s) of bread\nTotal: $29", newOrder.OrderTotal());
    }
    
  }
}