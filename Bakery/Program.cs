using System;
using Bakery;

class Prgram
{
  static void Main()
  {
    Console.WriteLine("Welcome To Pierre's Bakery");
    Console.WriteLine("----------------------------------------\nToday's Specials:\nBUY 2 OR MORE LOAFS OF BREAD AND GET EVERY THIRD FREE!\nBUY 2 OR MORE PASTRIES AND GET EVERY THIRD HALF OFF!\n----------------------------------------");
    Console.WriteLine("Would You like to order bread loafs or pastries?");
    string bakedGoodsChoice = Console.ReadLine();
    if (bakedGoodsChoice.ToLower() == "bread" || bakedGoodsChoice.ToLower() == "bread loafs")
    {
      Console.WriteLine("\nHow many loafs of bread do you want? \n<$" + Bread.PricePerLoaf + " per loaf>");
      int breadAmount = int.Parse(Console.ReadLine());
      Bread breadOrder = new Bread(breadAmount);
      breadOrder.BreadCost();
      Console.WriteLine("\nYour order is " + breadOrder.Amount + " loafs of bread\nTotal: $" + breadOrder.TotalCost);
    }
    else if (bakedGoodsChoice.ToLower() == "pastry" || bakedGoodsChoice.ToLower() == "pastries")
    {
      Console.WriteLine("\nHow many pastries do you want? \n<$" + Pastry.PricePerPastry + " per pastry>");
      int PastryAmount = int.Parse(Console.ReadLine());
      Pastry PastryOrder = new Pastry(PastryAmount);
      PastryOrder.PastryCost();
      Console.WriteLine("\nYour order is " + PastryOrder.Amount + " pastry(ies)\nTotal: $" + PastryOrder.TotalCost);
    }
    else
    {
      Console.WriteLine("\nInvalid Entry " + bakedGoodsChoice + " Is not an option, please try again\n");
      Main();
    }
  }
}