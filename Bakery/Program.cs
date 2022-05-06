using System;
using Bakery;

class Prgram
{
  static void Main()
  {
    Console.WriteLine("Welcome To Pierre's Bakery\nWould You like to order bread loafs or pastries?");
    string bakedGoodsChoice = Console.ReadLine();
    if (bakedGoodsChoice.ToLower() == "bread")
    {
      Console.WriteLine("\nHow many loafs of bread do you want? \n<$5 per loaf> BUY 2 OR MORE AND GET EVERY THIRD FREE!");
      int breadAmount = int.Parse(Console.ReadLine());
      Bread breadOrder = new Bread(breadAmount);
      breadOrder.BreadCost();
      breadOrder.BreadDiscountAdjust();
      Console.WriteLine("\nYour order is " + breadOrder.Amount + " loafs of bread\nTotal: $" + breadOrder.TotalCost);
    }
    else if (bakedGoodsChoice.ToLower() == "pastry" || bakedGoodsChoice.ToLower() == "pastries")
    {
      Console.WriteLine("\nHow many pastries do you want? \n<$2 per pastry> BUY 2 OR MORE AND GET EVERY THIRD HALF OFF!");
      int PastryAmount = int.Parse(Console.ReadLine());
      Pastry PastryOrder = new Pastry(PastryAmount);
      PastryOrder.PastryCost();
      PastryOrder.PastryDiscountAdjust();
      Console.WriteLine("\nYour order is " + PastryOrder.Amount + " pastry(ies)\nTotal: $" + PastryOrder.TotalCost);
    }
    else
    {
      Console.WriteLine("Invalid Entry " + bakedGoodsChoice + " Is not an option, please try again");
      Main();
    }
  }
}