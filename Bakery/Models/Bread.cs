using System;
namespace Bakery
{
  public class Bread
  {
    public int Amount {get; set;}
    public int PricePerLoaf {get; set;}
    public int TotalCost {get; set;}

    public Bread(int amount)
    {
      Amount = amount;
      PricePerLoaf = 5;
    }
    public void BreadCost()
    {
      TotalCost = Amount * PricePerLoaf;
    }
  }
}