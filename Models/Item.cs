namespace ivending.Models
{
  //NOTE Abstract enforces that a class cannot be instantiated
  abstract class Item
  {
    public string ItemName { get; private set; }
    public string ItemSlot { get; private set; }
    public int ItemCost { get; private set; }
    public int ItemQty { get; private set; }

    public Item(string itemName, string itemSlot, int itemCost, int itemQty)
    {
      ItemName = itemName;
      ItemSlot = itemSlot;
      ItemCost = itemCost;
      ItemQty = itemQty;
    }
  }
}