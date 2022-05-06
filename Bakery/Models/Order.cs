namespace Bakery
{
  public class Order
  {
    public Bread BreadOrder {get; set;}
    public Pastry PastryOrder {get; set;}
    public int OrderTotal {get; set;}

    public Order()
    {
      BreadOrder = new Bread(0);
      PastryOrder = new Pastry(0);
      OrderTotal = 0;
    }
    public string TotalCostOfOrder()
    {
      OrderTotal = BreadOrder.TotalCost + PastryOrder.TotalCost;
      if (BreadOrder.Amount > 0 && PastryOrder.Amount == 0)
      {
        if (BreadOrder.Amount == 1)
        {
          return "\nYour order is " + BreadOrder.Amount + " loaf of bread\nTotal: $" + OrderTotal;
        }
        else
        {
          return "\nYour order is " + BreadOrder.Amount + " loafs of bread\nTotal: $" + OrderTotal;
        }
      }
      else if (BreadOrder.Amount == 0 && PastryOrder.Amount > 0)
      {
        if (PastryOrder.Amount == 1)
        {
          return "\nYour order is " + PastryOrder.Amount + " pastry\nTotal: $" + OrderTotal;
        }
        else
        {
          return "\nYour order is " + PastryOrder.Amount + " pastries\nTotal: $" + OrderTotal;
        }
      }
      else if (BreadOrder.Amount > 0 && PastryOrder.Amount > 0)
      {
        if (BreadOrder.Amount == 1)
        {
          return "\nYour order is " + PastryOrder.Amount + " pastries and " + BreadOrder.Amount + " loaf of bread\nTotal: $" + OrderTotal;
        }
        else if (PastryOrder.Amount == 1)
        {
          return "\nYour order is " + PastryOrder.Amount + " pastry and " + BreadOrder.Amount + " loafs of bread\nTotal: $" + OrderTotal;
        }
        else if (BreadOrder.Amount == 1 && PastryOrder.Amount == 1)
        {
          return "\nYour order is " + PastryOrder.Amount + " pastry and " + BreadOrder.Amount + " loaf of bread\nTotal: $" + OrderTotal;
        }
        else
        {
          return "\nYour order is " + PastryOrder.Amount + " pastries and " + BreadOrder.Amount + " loafs of bread\nTotal: $" + OrderTotal;
        }
      }
      else
      {
        return "An Error Occured. " + BreadOrder.Amount + " or " + PastryOrder.Amount + " may be invalid numbers";
      }
    }
  }
}