using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        List<Category> categories = new List<Category>() {
             new Category { Name = "Elektronik", Id = 1 },
             new Category { Name = "Beyaz Eşya", Id = 2 },
             new Category { Name = "Küçük Ev Aletleri", Id = 3 },
        };

        List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Samsung S21 5g", Price = 15000, CategoryId = 1 },
            new Product { Id = 2, Name = "Iphone 14 pro max", Price = 80000, CategoryId = 1 },
            new Product { Id = 3, Name = "Iphone 14", Price = 65000, CategoryId = 1 },
            new Product { Id = 4, Name = "Buzdolabı", Price = 10000, CategoryId = 2 },
            new Product { Id = 5, Name = "Çamaşır Makinesi", Price = 6000, CategoryId = 2 },
            new Product { Id = 6, Name = "Televizyon", Price = 15000, CategoryId = 2 },
            new Product { Id = 7, Name = "Fırın", Price = 13000, CategoryId = 2 },
            new Product { Id = 8, Name = "Huawei", Price = 6000, CategoryId = 1 },
            new Product { Id = 9, Name = "Tost Makinesi", Price = 1000, CategoryId = 3 },
            new Product { Id = 10, Name = "Ütü", Price = 5000, CategoryId = 3 },
            new Product { Id = 11, Name = "Saç Kurutma Makinası", Price = 500, CategoryId = 3 },
        };

        List<Sales> sales = new List<Sales>()
        {
            new Sales { ProductId = 1, Amount = 1500 },
            new Sales { ProductId = 2, Amount = 1000 },
            new Sales { ProductId = 3, Amount = 1500 },
            new Sales { ProductId = 4, Amount = 4650 },
            new Sales { ProductId = 5, Amount = 3700 },
            new Sales { ProductId = 6, Amount = 4800 },
            new Sales { ProductId = 7, Amount = 2380 },
            new Sales { ProductId = 8, Amount = 700 },
            new Sales { ProductId = 9, Amount = 670 },
            new Sales { ProductId = 10, Amount = 1250 },
            new Sales { ProductId = 11, Amount = 2000 },
        };

        var productCategories = products.Join(categories, p => p.CategoryId, c => c.Id, (product, category) => new
        {
            ProductName = product.Name,
            CategoryName = category.Name,
            Price = product.Price
        });

        var groupedProducts = productCategories.GroupBy(x => x.CategoryName);

        foreach (var group in groupedProducts)
        {
            Console.WriteLine($"{group.Key}:");
            foreach (var item in group)
            {
                var sale = sales.FirstOrDefault(s => products.Any(p => p.Name == item.ProductName && p.Id == s.ProductId));
                Console.WriteLine($"  Product: {item.ProductName} - Price: {item.Price:C} - Sale: {sale?.Amount}");
            }


            var lowestSalesProducts = group
                .OrderBy(item => sales.FirstOrDefault(s => products.Any(p => p.Name == item.ProductName && p.Id == s.ProductId))?.Amount)
                .Take(2);

            Console.WriteLine($"En Az Satılan Ürünler:");
            foreach (var item in lowestSalesProducts)
            {
                var sale = sales.FirstOrDefault(s => products.Any(p => p.Name == item.ProductName && p.Id == s.ProductId));
                Console.WriteLine($"  Product: {item.ProductName} - Price: {item.Price:C} - Sale: {sale?.Amount}");
            }
        }
    }

    public class Sales
    {
        public int Amount { get; set; }
        public int ProductId { get; set; }
    }

    class Product
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }

    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}