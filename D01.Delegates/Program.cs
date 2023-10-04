class Program
{
    public static void Main(string[] args)
    {

    }

    public static void Test()
    {
        Console.WriteLine("Test2");
    }


    public static void GetProductName(Product product)
    {
        Console.WriteLine("Product name - " + product.Name);
    }

    public static void GetProductId(Product product)
    {
        Console.WriteLine("Product Id - " + product.Id);
    }

    public static void SayHello2(string name)
    {
        Console.WriteLine("Hello" + name);
    }

    public static int ConvertToInt(string value)
    {
        var control = int.TryParse(value, out var returnValue);

        if (control)
        {
            return returnValue;
        }
        return -1;

    }

    public static void SayHello(string name1, string name2)
    {
        Console.WriteLine("Hello" + name1 + "-" + name2);
    }

    public static void SayWelcome(string name1, string name2)
    {
        Console.WriteLine("Welcome" + name1 + "-" + name2);
    }

    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
    }

}