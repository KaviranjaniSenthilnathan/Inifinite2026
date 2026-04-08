using System;
{
    class Product
    {
        public int ProductId;
        public string ProductName;
        public double Price;

        public void Display()
        {
            Console.WriteLine($"{ProductId,-5} {ProductName,-15} {Price,8}");
        }
    }

    class ProductProgram
    {
        public static void Run()
        {
            Product[] products = new Product[10]
            {
                new Product { ProductId = 101, ProductName = "Pen", Price = 5 },
                new Product { ProductId = 108, ProductName = "Bottle", Price = 8 },
                new Product { ProductId = 106, ProductName = "Notebook", Price = 10 },
                new Product { ProductId = 102, ProductName = "Book", Price = 15 },
                new Product { ProductId = 104, ProductName = "Mouse", Price = 20 },
                new Product { ProductId = 105, ProductName = "Keyboard", Price = 25 },
                new Product { ProductId = 107, ProductName = "Bag", Price = 50 },
                new Product { ProductId = 109, ProductName = "Chair", Price = 120 },
                new Product { ProductId = 110, ProductName = "Table", Price = 200 },
                new Product { ProductId = 103, ProductName = "Laptop", Price = 500 }
            };

            Console.WriteLine("\nProducts sorted by Price:\n");
            Console.WriteLine("ID    Name             Price");

            Array.Sort(products, (p1, p2) => p1.Price.CompareTo(p2.Price));

            foreach (Product p in products)
            {
                p.Display();
            }
        }
    }
}