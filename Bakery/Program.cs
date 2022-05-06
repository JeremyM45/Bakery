using System;
using Bakery;

class Program
{
  static Pastry OrderPastries()
  {
    Console.WriteLine("\nHow many pastries do you want? \n<$" + Pastry.PricePerPastry + " per pastry>");
    int PastryAmount = int.Parse(Console.ReadLine());
    Pastry pastryOrder = new Pastry(PastryAmount);
    return pastryOrder;
  }
  static Bread OrderBread()
  {
    Console.WriteLine("\nHow many loafs of bread do you want? \n<$" + Bread.PricePerLoaf + " per loaf>");
    int breadAmount = int.Parse(Console.ReadLine());
    Bread breadOrder = new Bread(breadAmount);
    return breadOrder;
  }
  static void Main()
  {
    Console.WriteLine("Welcome To Pierre's Bakery");
    Console.WriteLine("----------------------------------------\nToday's Specials:\nBUY 2 OR MORE LOAFS OF BREAD AND GET EVERY THIRD FREE!\nBUY 2 OR MORE PASTRIES AND GET EVERY THIRD HALF OFF!\n----------------------------------------");
    Console.WriteLine("Would You like to order bread loafs or pastries?");
    string bakedGoodsChoice = Console.ReadLine();
    Order userOrder = new Order();
    if (bakedGoodsChoice.ToLower() == "bread" || bakedGoodsChoice.ToLower() == "bread loafs")
    {
      userOrder.BreadOrder = OrderBread();
      userOrder.BreadOrder.BreadCost();
      Console.WriteLine("Would you like to add pastries to your order? Y/N");
      string orderMore = Console.ReadLine();
      if(orderMore.ToLower() == "y")
      {
        userOrder.PastryOrder = OrderPastries();
        userOrder.PastryOrder.PastryCost();
      } 
      else if (orderMore.ToLower() != "y" && orderMore.ToLower() != "n")
      {
        Console.WriteLine("Error Invalid Input: " + orderMore + " is not Y or N\n");
      }
    }
    else if (bakedGoodsChoice.ToLower() == "pastry" || bakedGoodsChoice.ToLower() == "pastries")
    {
      userOrder.PastryOrder = OrderPastries();
      userOrder.PastryOrder.PastryCost();
      Console.WriteLine("Would you like to add bread to your order? Y/N");
      string orderMore = Console.ReadLine();
      if(orderMore.ToLower() == "y")
      {
        userOrder.BreadOrder = OrderBread();
        userOrder.BreadOrder.BreadCost();
      }
      else (orderMore.ToLower() != "y" && orderMore.ToLower() != "n")
      {
        Console.WriteLine("Error Invalid Input: " + orderMore + " is not Y or N");
      }
    }
    else
    {
      Console.WriteLine("\nInvalid Entry " + bakedGoodsChoice + " Is not an option, please try again\n");
      Main();
    }
    Console.WriteLine(userOrder.TotalCostOfOrder());
  }
}