using System.Collections.Generic;

namespace BakeryApp.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name {get; set;}
    public string Description {get; set;}
    public int Id {get;}
    public List<Order> Orders {get; set;}

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }

    public static List<Vendor> GetAll()
    {
      if (_instances.Count == 0)
      {
        Console.WriteLine("No current vendors");
      }
      return _instances;
    }

    public static void CLearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int findId)
    {
      return _instances[findId-1];
    }

    public void AddOrder(Order order)
    {
      Order.Add(order);
    }

  }

}