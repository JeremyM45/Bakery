using System;
namespace Bakery
{
  public class Pastry
  {
    public int Amount {get; set;}
    public int PricePerPastry {get; set;}
    public int TotalCost {get; set;}

    public Pastry(int amount)
    {
      Amount = amount;
      PricePerPastry = 2;
    }
    public void PastryCost()
    {
      TotalCost = Amount * PricePerPastry;
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