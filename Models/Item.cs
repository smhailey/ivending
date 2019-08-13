namespace ivending.Models
{
  //NOTE Abstract enforces that a class cannot be instantiated
  abstract class Item
  {
    public string ItemName { get; private set; }
    public int ItemCost { get; private set; }

    public Item(string itemName, int itemCost)
    {
      ItemName = itemName;
      ItemCost = itemCost;
    }
  }
}