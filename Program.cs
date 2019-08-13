using System;
using ivending.Models;
// using ivending.Interfaces;

namespace ivending.Models
{
  class Program
  {
    static void Main(string[] args)
    {
      Machine ivend = new Machine("CodeWorks Location");
      Food beefJerky = new Food("Beef Jerky", "A-1", 2, 12);
      Food riceCandy = new Food("Tasty Good Rice Candy", "B-1", 1, 12);
      Food iceCream = new Food("Ice Cream", "C-1", 3, 12);
      ivend.AddFoodItem(beefJerky);
      ivend.AddFoodItem(iceCream);
      ivend.AddFoodItem(riceCandy);



      bool quit = false;
      Console.WriteLine("Welcome to iVending");
      while (!quit)
      {
        // Console.Clear();
        System.Console.WriteLine();
        Console.WriteLine("Here are your choices:");
        Console.WriteLine("1 - View available food items");
        Console.WriteLine("2 - View available drink items");
        Console.WriteLine("3 - View available electronics items");
        Console.WriteLine("4 - Quit");
        Console.WriteLine("Please enter a number to continue:");
        var userInput = Console.ReadLine();
        System.Console.WriteLine();
        if (Int32.TryParse(userInput, out int choice))
        {
          switch (choice)
          {
            case 1:
              ivend.ViewFoodItems();
              break;
            case 2:
              //   ivend.ViewDrinkItems();
              break;
            case 3:
              //   ivend.ViewElectronicItems();
              break;
            case 4:
              quit = true;
              //   Console.Clear();
              Console.WriteLine("Goodbye");
              break;
            default:
              System.Console.WriteLine("Invalid Choice Try again");
              break;
          }
        }
      }
    }
  }
}
