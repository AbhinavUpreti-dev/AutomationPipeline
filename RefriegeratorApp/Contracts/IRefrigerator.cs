
namespace RefrigeratorApp
{
    public interface IRefrigerator
    {
        void ConsumeProduct(Product product, int quantity);
        List<Consumption> GetConsumptionHistory();
        List<Product> GetCurrentProducts();
        List<Product> GetExpiringProducts();
        List<Purchase> GetPurchaseHistory();
        void InsertProduct(Product product, int quantity);
    }
}