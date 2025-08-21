using System;

namespace Problem_1
{
    internal class Car
    {
        // Properties
        public int Id { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }

        // 1- Default constructor
        public Car()
        {
            Id = 0;
            Brand = "Unknown";
            Price = 0.0;
        }

        // 2- Constructor with one parameter (Id)
        public Car(int _id) : this(_id, "BMW", 25000) { }

        // 3- Constructor with two parameters (Id, Brand)
        public Car(int _id, string _Brand) : this(_id, _Brand, 50000) { }

        // 4- Constructor with all three parameters
        public Car(int _Id, string _Brand, double _Price)
        {
            Id = _Id;
            Brand = _Brand;
            Price = _Price;
        }

        public override string ToString()
        {
            return $"id : {Id}, Brand : {Brand}, Price : {Price}";
        }

    }
}
