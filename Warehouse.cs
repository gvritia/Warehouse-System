using System.Collections.Generic;
using WarehouseSystem.Properties;

namespace WarehouseSystem
{
    public class Warehouse
    {
        
        public readonly int Id;
        
        public readonly WarehouseType Type;
        
        public string Name { get; set; }
        
        public float Volume { get; set; }
        
        public float Price { get; set; }
        
        public int ExpDays { get; set; }

        public List<Product> Products { get; } = new List<Product>();


        public Warehouse(int id, WarehouseType type, string name, float volume, float price, int expDays)
        {
            
            Id = id;
            Type = type;
            Name = name;
            Volume = volume;
            Price = price;
            ExpDays = expDays;
            
        }
        
        
    }
}