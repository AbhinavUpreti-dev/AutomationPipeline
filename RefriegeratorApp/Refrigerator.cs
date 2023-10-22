namespace RefrigeratorApp
{
    public class Refrigerator : IRefrigerator
    {
        private List<Product> _products;
        private List<Purchase> _purchases;
        private List<Consumption> _consumptions;

        public Refrigerator()
        {
            _products = new List<Product>();
            _purchases = new List<Purchase>();
            _consumptions = new List<Consumption>();
        }

        public void InsertProduct(Product product, int quantity)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Name == product.Name);
            if (existingProduct != null)
            {
                existingProduct.Quantity += quantity;
            }
            else
            {
                _products.Add(product);
            }

            _purchases.Add(new Purchase { Product = product, Quantity = quantity, Date = DateTime.Now });
        }

        public void ConsumeProduct(Product product, int quantity)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Name == product.Name);
            if (existingProduct != null)
            {
                existingProduct.Quantity -= quantity;
            }

            _consumptions.Add(new Consumption { Product = product, Quantity = quantity, Date = DateTime.Now });
        }

        public List<Product> GetCurrentProducts()
        {
            return _products;
        }

        public List<Purchase> GetPurchaseHistory()
        {
            return _purchases;
        }

        public List<Consumption> GetConsumptionHistory()
        {
            return _consumptions;
        }

        public List<Product> GetExpiringProducts()
        {
            var expiringProducts = new List<Product>();

            foreach (var product in _products)
            {
                if (product.ExpirationDate.HasValue && product.ExpirationDate.Value <= DateTime.Now.AddDays(7))
                {
                    expiringProducts.Add(product);
                }
            }

            return expiringProducts;
        }
    }
}
