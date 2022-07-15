using System;
using System.Collections.Generic;

namespace PierreBakery.Models
{
  public class Bread
  {
    
    public int Quantity { get; set; }
    public Bread(int numBreadOrder)
    {
      Quantity = numBreadOrder;
    }
    
    public static int BreadOrder(int Quantity)
    {
      return Quantity * 5;
    }

    public static int SpecialDeal(int Quantity)
    {
      int breadReceive = Quantity;
      if (Quantity >= 2)
      {
        return breadReceive + 1;
      }
      else
      {
        return breadReceive;
      }
    }
  }
}