using System.Text.Json;


namespace Invoice
{
    public class ProductCatalog
    {
        public Dictionary<string, Product> Products { get; set; } = [];

        public void LoadProducts()
        {
            string json = File.ReadAllText("product_cataloge.json");

            Products = JsonSerializer.Deserialize<Dictionary<string, Product>>(json)
                ?? [];
        }
    }
}