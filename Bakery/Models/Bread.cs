using System;
namespace Bakery
{
  public class Bread
  {
    public int Amount {get; set;}
    public static int PricePerLoaf {get; set;} = 5;
    public int TotalCost {get; set;}

    public Bread(int amount)
    {
      Amount = amount;
    }
    public void BreadCost()
    {
      TotalCost = Amount * PricePerLoaf;
      BreadDiscountAdjust();
    }
    public void BreadDiscountAdjust()
    {
      for (int i = 1; i <= Amount; i++)
      {
        if(i % 3 == 0)
        {
          TotalCost -= PricePerLoaf;
        }
      }
    }
  }
}