using RefrigeratorApp;

public class Program
{

    public static void Main(string[] args)
    {
        var refrigerator = new Refrigerator();

        while (true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Insert product");
            Console.WriteLine("2. Consume product");
            Console.WriteLine("3. View current stock");
            Console.WriteLine("4. View purchase history");
            Console.WriteLine("5. View consumption history");
            Console.WriteLine("6. View expiring products");
            Console.WriteLine("7. Exit");

            var option = Console.ReadLine();
            var product = new Product { Id = 1, Name = "Test", ExpirationDate = DateTime.Now.AddDays(100), Type = ProductType.Milk };

            switch (option)
            {
                case "1":
                    refrigerator.InsertProduct(product, 10);
                    Console.WriteLine("Insert SuccessFul");
                    break;
                case "2":
                    refrigerator.ConsumeProduct(product, 10);
                    break;
                case "3":
                    PrintProducts(refrigerator.GetCurrentProducts());
                    break;
                case "4":
                    PrintPurchases(refrigerator);
                    break;
                case "5":
                    PrintConsumptions(refrigerator);
                    break;
                case "6":
                    PrintProducts(refrigerator.GetExpiringProducts());
                    break;
                case "7":
                    return;
            }

        }
    }

    private static void PrintConsumptions(Refrigerator refrigerator)
    {
        var consumptions = refrigerator.GetConsumptionHistory();
        if (consumptions.Count > 0)
        {
            foreach (var consumption in consumptions)
            {
                Console.WriteLine($"Consumption Product : {consumption?.Product?.Name} on : ({consumption?.Date})");
            }
        }
    }

    private static void PrintPurchases(Refrigerator refrigerator)
    {
        List<Purchase> purchases = refrigerator.GetPurchaseHistory();
        if (purchases.Count > 0)
        {
            foreach (var purchase in purchases)
            {
                Console.WriteLine($"Purchase Name : {purchase?.Product?.Name} with Quantity : ({purchase?.Quantity})");
            }
        }
    }


    private static void PrintProducts(List<Product> products)
    {
        if (products.Count > 0)
        {
            foreach (var prod in products)
            {
                Console.WriteLine($"Product Name : {prod.Name} with Quantity : ({prod.Quantity})");
            }
        }
    }
}
