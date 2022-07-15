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
      Console.WriteLine("We have deals on loaves bread buy one at $5 or 2 at $10 and get the third one free");
      Console.WriteLine("Pastry buy 1 for $2 or 3 for $5. Four pastries costs $7, five pastries costs $9, and six pastries costs $10");
      FindFinalPrice();
      static void FindFinalPrice()
      {
        Console.WriteLine("Enter how many loaves bread do you want?");
        string userInputBread = Console.ReadLine();
        int inputBread = int.Parse(userInputBread);
        Console.WriteLine("Enter how many pastry do you want?");
        string userInputPastry = Console.ReadLine();
        int inputPastry = int.Parse(userInputPastry);

        int orderOfBread = Bread.SpecialDeal(inputBread);
        int orderTotal = Bread.BreadOrder(inputBread) + Pastry.PastryOrder(inputPastry);

        Console.WriteLine("Your total is $" + orderTotal + ". You have order " + orderOfBread + " loaves of bread and " + inputPastry + " pastry.");
        Console.WriteLine("Would you like to order more loaves of bread and pastry? If so enter 'Y' or 'y'. Crtl C to exit");
        string answer = Console.ReadLine();
        if (answer == "y" || answer == "Y")
        {
          FindFinalPrice();
        }
        else
        {
          Main();
        }
      }
    }
  }
}