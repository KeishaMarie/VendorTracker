using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Description { get; set;}
    public string Details { get; set; }
    public int Price { get; set; }
    public int Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};




    public Order (string description, string details, int price, int date)
    {
      Description = description;
      Details = details;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;

    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}