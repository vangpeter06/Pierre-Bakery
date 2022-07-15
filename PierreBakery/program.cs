using System;
using System.Collections.Generic;
using PierreBakery.Models;

namespace PierreBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre Bakery");
      Console.WriteLine("We have deals on bread buy one at $5 or 2 at $10 and get the third one free");
      Console.WriteLine("Pastry buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10");
      FindFinalPrice();
      static void FindFinalPrice()
      {
        Console.WriteLine("Enter how many bread do you want?");
        string userInputBread = Console.ReadLine();
        int inputBread = int.Parse(userInputBread);
        Console.WriteLine("Enter how many pastry do you want?");
        string userInputPastry = Console.ReadLine();
        // int inputPastry = int.Parse(userInputPastry);Bread breadTotal = new Bread(inputBread);
        
        // Console.WriteLine("Your total for bread is $" + breadTotal.BreadOrder(inputBread));
        
        // Pastry pastryTotal = new Pastry(inputPastry);
        // Console.WriteLine(breadTotal, pastryTotal);
        {
          FindFinalPrice();
        }
      }
    }
  }
}