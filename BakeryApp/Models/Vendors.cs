using System.Collections.Generic;

namespace BakeryApp.Models
{
    public class Vendor
    {
        private static List<Vendor> _instances = new List<Vendor> {};
        public string Name {get; set;}
        public string Description {get; set;}
        public int Id {get; set;}
        public List<Order> Orders {get; set;}
    }
}