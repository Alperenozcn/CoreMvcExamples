class Program
{

    delegate void TestDelegate(int parameter1, int parameter2);
    static void Main(string[] args)
    {

        //TestDelegate testDelegate = new TestDelegate(Topla);

        //testDelegate += Carp;
        //testDelegate.Invoke(1, 2);
        //testDelegate.Invoke(3, 4);

        // LINQ x=>x

        // Func<Product, string> funcDelegate = new Func<Product, string>(GetProductName);

        //var productName =  funcDelegate.Invoke(list[0]);

        // Console.WriteLine(productName);

        // //Func Predicate Action 

        // //list.ForEach()

        var list = new List<Product>()
        {
            new Product{Id = 1, Name="Samsung S21 5g", Price =15000},
            new Product{Id = 2, Name="Iphone 15", Price =70000}
        };


        //Action<Product> actionDelegate = new Action<Product>(GetProductName);
        //actionDelegate += GetPrice;
        //actionDelegate += GetProductId;


        //var actionDelegate2 = (Product product) =>
        //{
        //    Console.WriteLine($"Product  Name  : {product.Name}");
        //}; 







        //actionDelegate2+= GetProductName;



        //list.ForEach(actionDelegate2);

        //list.ForEach();

        //var abc = (Product x) =>
        //{
        //    return x.Name;
        //};

        //Predicate<>

        Console.WriteLine("Hello world");
    }

    static void GetProductName(Product product)
    {
        Console.WriteLine($" Product Name : {product.Name}");
    }

    static void GetProductId(Product product)
    {
        Console.WriteLine($" Product Id :{product.Id}");
    }

    static void GetPrice(Product product)
    {
        Console.WriteLine($" Product price : {product.Price}");
    }



    static void Topla(int x, int y)
    {
        Console.WriteLine($"Result : {x + y}");
    }

    static void Carp(int x, int y)
    {
        Console.WriteLine($"Result : {x * y}");
    }

    static void Cikar(int x, int y)
    {
        Console.WriteLine($"Result : {x - y}");
    }
}
class Product
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Price { get; set; }

}