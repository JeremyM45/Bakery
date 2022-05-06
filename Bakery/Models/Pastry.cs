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
  }
}