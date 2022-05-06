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
        return "\nYour order is " + BreadOrder.Amount + " loaf(s) of bread\nTotal: $" + OrderTotal;
      }
      else if (BreadOrder.Amount == 0 && PastryOrder.Amount > 0)
      {
        return "\nYour order is " + PastryOrder.Amount + " pastry(ies)\nTotal: $" + OrderTotal;
      }
      else if (BreadOrder.Amount > 0 && PastryOrder.Amount > 0)
      {
        return "\nYour order is " + PastryOrder.Amount + " pastry(ies) and " + BreadOrder.Amount + " loaf(s) of bread\nTotal: $" + OrderTotal;
      }
      else
      {
        return "An Error Occured. " + BreadOrder.Amount + " or " + PastryOrder.Amount + " may be invalid numbers";
      }
    }
  }
}