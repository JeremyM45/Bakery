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
      Assert.AreEqual("\nYour order is 5 loafs of bread\nTotal: $20", newOrder.TotalCostOfOrder());
    }
    [TestMethod]
    public void TotalCostOfOrder_ReturnsTheOrderTotalMessageFor0BreadLoafsAnd5Pastries_String()
    {
      Order newOrder = new Order();
      newOrder.BreadOrder = new Bread(0);
      newOrder.BreadOrder.BreadCost();
      newOrder.PastryOrder = new Pastry(5);
      newOrder.PastryOrder.PastryCost();
      Assert.AreEqual("\nYour order is 5 pastries\nTotal: $9", newOrder.TotalCostOfOrder());
    }
    [TestMethod]
    public void TotalCostOfOrder_ReturnsTheOrderTotalMessageFor5BreadLoafsAnd5Pastries_String()
    {
      Order newOrder = new Order();
      newOrder.BreadOrder = new Bread(5);
      newOrder.BreadOrder.BreadCost();
      newOrder.PastryOrder = new Pastry(5);
      newOrder.PastryOrder.PastryCost();
      Assert.AreEqual("\nYour order is 5 pastries and 5 loafs of bread\nTotal: $29", newOrder.TotalCostOfOrder());
    }
    [TestMethod]
    public void TotalCostOfOrder_ReturnsTheOrderTotalMessageFor1BreadLoafsAnd0Pastries_String()
    {
      Order newOrder = new Order();
      newOrder.BreadOrder = new Bread(1);
      newOrder.BreadOrder.BreadCost();
      newOrder.PastryOrder = new Pastry(0);
      newOrder.PastryOrder.PastryCost();
      Assert.AreEqual("\nYour order is 1 loaf of bread\nTotal: $5", newOrder.TotalCostOfOrder());
    }
    [TestMethod]
    public void TotalCostOfOrder_ReturnsTheOrderTotalMessageFor0BreadLoafsAnd1Pastries_String()
    {
      Order newOrder = new Order();
      newOrder.BreadOrder = new Bread(0);
      newOrder.BreadOrder.BreadCost();
      newOrder.PastryOrder = new Pastry(1);
      newOrder.PastryOrder.PastryCost();
      Assert.AreEqual("\nYour order is 1 pastry\nTotal: $2", newOrder.TotalCostOfOrder());
    }
    [TestMethod]
    public void TotalCostOfOrder_ReturnsTheOrderTotalMessageFor1BreadLoafsAnd5Pastries_String()
    {
      Order newOrder = new Order();
      newOrder.BreadOrder = new Bread(1);
      newOrder.BreadOrder.BreadCost();
      newOrder.PastryOrder = new Pastry(5);
      newOrder.PastryOrder.PastryCost();
      Assert.AreEqual("\nYour order is 5 pastries and 1 loaf of bread\nTotal: $14", newOrder.TotalCostOfOrder());
    }
    [TestMethod]
    public void TotalCostOfOrder_ReturnsTheOrderTotalMessageFor5BreadLoafsAnd1Pastries_String()
    {
      Order newOrder = new Order();
      newOrder.BreadOrder = new Bread(5);
      newOrder.BreadOrder.BreadCost();
      newOrder.PastryOrder = new Pastry(1);
      newOrder.PastryOrder.PastryCost();
      Assert.AreEqual("\nYour order is 1 pastry and 5 loafs of bread\nTotal: $22", newOrder.TotalCostOfOrder());
    }
    [TestMethod]
    public void TotalCostDiscountAdjust_Returns5PercentDiscountOnOrderOver20_Int()
    {
      Order newOrder = new Order();
      newOrder.BreadOrder = new Bread(7);
      newOrder.BreadOrder.BreadCost();
      newOrder.PastryOrder = new Pastry(14);
      newOrder.PastryOrder.PastryCost();
      newOrder.TotalCostOfOrder();
      newOrder.TotalCostDiscountAdjust();
      Assert.AreEqual(44.10, newOrder.OrderTotal);
    }
  }
}