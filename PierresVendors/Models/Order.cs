using System.Collections.Generic;
using System;

namespace PierresVendors.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public double Price { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string description, double price, string title, DateTime date)
    {
      Title = title;
      Description = description;
      Date = date;
      Price = price;
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
