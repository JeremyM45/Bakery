using System;
using Bakery;

class Program
{
  static Pastry PastryOrder()
  {
      Console.WriteLine("\nHow many pastries do you want? \n<$" + Pastry.PricePerPastry + " per pastry>");
      int PastryAmount = int.Parse(Console.ReadLine());
      Pastry pastryOrder = new Pastry(PastryAmount);
      return pastryOrder;
  }
  static Bread BreadOrder()
  {
    Console.WriteLine("\nHow many loafs of bread do you want? \n<$" + Bread.PricePerLoaf + " per loaf>");
    int breadAmount = int.Parse(Console.ReadLine());
    Bread breadOrder = new Bread(breadAmount);
    return breadOrder;
  }
  static void DisplayTotal(Bread breadOrder, Pastry pastryOrder)
  {
    int totalPrice = breadOrder.TotalCost + pastryOrder.TotalCost;
    if (breadOrder.Amount > 0 && pastryOrder.Amount == 0)
    {
      Console.WriteLine("\nYour order is " + breadOrder.Amount + " loaf(s) of bread\nTotal: $" + totalPrice);
    }
    else if (breadOrder.Amount == 0 && pastryOrder.Amount > 0)
    {
      Console.WriteLine("\nYour order is " + pastryOrder.Amount + " pastry(ies)\nTotal: $" + totalPrice);
    }
    else if (breadOrder.Amount > 0 && pastryOrder.Amount > 0)
    {
      Console.WriteLine("\nYour order is " + pastryOrder.Amount + " pastry(ies) and " + breadOrder.Amount + " loaf(s) of bread\nTotal: $" + totalPrice);
    }
    
  }
  static void Main()
  {
    Console.WriteLine("Welcome To Pierre's Bakery");
    Console.WriteLine("----------------------------------------\nToday's Specials:\nBUY 2 OR MORE LOAFS OF BREAD AND GET EVERY THIRD FREE!\nBUY 2 OR MORE PASTRIES AND GET EVERY THIRD HALF OFF!\n----------------------------------------");
    Console.WriteLine("Would You like to order bread loafs or pastries?");
    string bakedGoodsChoice = Console.ReadLine();
    Bread breadOrder = new Bread(0);
    Pastry pastryOrder = new Pastry(0);
    if (bakedGoodsChoice.ToLower() == "bread" || bakedGoodsChoice.ToLower() == "bread loafs")
    {
      breadOrder = BreadOrder();
      breadOrder.BreadCost();
      Console.WriteLine("Would you like to add pastries to your order? Y/N");
      string orderMore = Console.ReadLine();
      if(orderMore.ToLower() == "y")
      {
        pastryOrder = PastryOrder();
        pastryOrder.PastryCost();
      }
    }
    else if (bakedGoodsChoice.ToLower() == "pastry" || bakedGoodsChoice.ToLower() == "pastries")
    {
      pastryOrder = PastryOrder();
      pastryOrder.PastryCost();
      Console.WriteLine("Would you like to add bread to your order? Y/N");
      string orderMore = Console.ReadLine();
      if(orderMore.ToLower() == "y")
      {
        breadOrder = BreadOrder();
        breadOrder.BreadCost();
      }
    }
    else
    {
      Console.WriteLine("\nInvalid Entry " + bakedGoodsChoice + " Is not an option, please try again\n");
      Main();
    }
    DisplayTotal(breadOrder, pastryOrder);
  }
}