using System;
using System.Collections.Generic;

namespace PierreBakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public Pastry(int numPastryOrder)
    {
      Quantity = numPastryOrder;
    }
  
    public static int PastryOrder(int Quantity)
    {
      int orderAmount = Quantity * 2;

      if (Quantity == 3)
      {  
        return 5;
      }
       else if (Quantity > 3)
      {
        return Quantity * 2 -1;
      }
      else if (Quantity == 6)
      {
        return 10;
      }
      else 
      {
        return orderAmount ;
      }
    }
  }
}