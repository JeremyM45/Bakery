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
  }
}