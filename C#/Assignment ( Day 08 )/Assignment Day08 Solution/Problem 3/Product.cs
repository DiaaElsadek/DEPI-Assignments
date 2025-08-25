using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    internal class Product : ICloneable, IComparable
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Product(Product Copy)
        {
            Id = Copy.Id;
            Name = Copy.Name;
            Price = Copy.Price;
        }

        public Product() { }

        public int CompareTo(object obj)
        {
            Product PassProduct = (Product)obj; 

            if (this.Price > PassProduct.Price)
                return 1;
            else if (this.Price < PassProduct.Price)
                return -1;
            else
                return 0;
        }

        override public string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Price: {Price}";
        }

        public object Clone()
        {
            return new Product()
            {
                Id = this.Id,
                Name = this.Name,
                Price = this.Price,
            };
        }
    }
}
