using System;
namespace Bakery
{
  public class Pastry
  {
    public int Amount {get; set;}
    public static int PricePerPastry {get; set;} = 2;
    public int TotalCost {get; set;}

    public Pastry(int amount)
    {
      Amount = amount;
    }
    public void PastryCost()
    {
      TotalCost = Amount * PricePerPastry;
      PastryDiscountAdjust();
    }
    public void PastryDiscountAdjust()
    {
      for (int i = 1; i <= Amount; i++)
      {
        if(i % 3 == 0)
        {
          TotalCost -= (PricePerPastry / 2);
        }
      }
    }
  }
}