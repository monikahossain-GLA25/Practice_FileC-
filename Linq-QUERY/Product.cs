using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_QUERY
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public double Rating { get; set; }
        public int SupplierId { get; set; }
        public static void Main(string[] args)
        {
            List<Product> pro = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Brand = "Dell",
                    Category = "Electronics",
                    Price = 800.00m,
                    Stock = 10,
                    Rating = 4.5,
                    SupplierId = 101

                },
                new Product
                {
                    Id = 2,
                    Name = "Smartphone",
                    Brand = "Samsung",
                    Category = "Electronics",
                    Price = 600.00m,
                    Stock = 20,
                    Rating = 4.2,
                    SupplierId = 102
                },
                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Brand = "Sony",
                    Category = "Electronics",
                    Price = 150.00m,
                    Stock = 15,
                    Rating = 4.0,
                    SupplierId = 103
                },
                 new Product
                 {
                     Id = 4,
                    Name = "Refrigerator",
                    Brand = "LG",
                    Category = "Appliances",
                    Price = 1200.00m,
                    Stock = 5,
                    Rating = 4.3,
                    SupplierId = 104
                 },
                 new Product
                    {
                        Id = 5,
                        Name = "Microwave",
                        Brand = "Panasonic",
                        Category = "Appliances",
                        Price = 200.00m,
                        Stock = 8,
                        Rating = 4.1,
                        SupplierId = 105
                    }

            };
            var findAll = pro.Where(p => p.Price >= 7000).ToList();
            foreach (var item in findAll)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Brand: {item.Brand}, Category: {item.Category}, Price: {item.Price}, Stock: {item.Stock}, Rating: {item.Rating}, SupplierId: {item.SupplierId}");
            }
            var project = pro.Select(p => new
            {
                p.Name,
                p.Brand,
                p.Price
            });
            foreach (var item in project)
            {
                Console.WriteLine($"Name: {item.Name}, Brand: {item.Brand}, Price: {item.Price}");
            }
        }
    }
}
 

