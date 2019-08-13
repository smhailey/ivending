using System;
using System.Collections.Generic;

namespace ivending.Models
{
  class Machine
  {
    public string Location { get; private set; }
    private List<Item> AvailableItems { get; set; }

    public void ViewFoodItems()
    {
      for (int index = 0; index < AvailableItems.Count; index++)
      {
        Item n = AvailableItems[index];
        System.Console.WriteLine($"{index + 1}. {n.ItemName} Location: {n.ItemSlot} Price: ${n.ItemCost}");
      }
    }


    public void AddFoodItem(Item n)
    {
      AvailableItems.Add(n);
    }









    public Machine(string location)
    {
      Location = location;
      AvailableItems = new List<Item>();

    }
  }
}