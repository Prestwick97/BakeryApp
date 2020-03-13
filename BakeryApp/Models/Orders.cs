using System;
using System.Collections.Generic;

namespace BakeryApp.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public int Price {get; set;}
    public string Date {get; set;}
    public int Id {get;}
    private static List<Order> _instances = new List<Order> {};

    public Order(string title, string decription, int price, string date)
    {
      Title = title;
      Description = Description;
      Price = price;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      if (_instances.Count == 0)
      {
        Console.WriteLine("No orders for vendor");
      }
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int findId)
    {
      return _instances[findId-1];
    }

  }
}