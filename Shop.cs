

using System.Text.Json;

namespace Invoice
{
    public class Shop
    {
        private ProductCatalog catalog = new ProductCatalog();
        private List<Product> selectedProducts = [];
        public void BuyFromShop()
        {
            // create the list of products
            var buyList = new List<string> { };
            // the absolute path to where to store the file
            var customerBuyListFile = "C:\\Users\\s1031\\Documents\\GitHub\\Invoice";

            // add the selected products to the customerbuylist


            // save the list as a text file
            File.WriteAllLines(customerBuyListFile, buyList);


        }

        public void BrowseProductCataloge()
        {
            // read the catalog and present it to user
            string json = File.ReadAllText("product_cataloge.json");
            Dictionary<string, Product>? products =
      JsonSerializer.Deserialize<Dictionary<string, Product>>(json); // use the jsonserializer bundle to create an instance of the Product class for each object in the cataloge

            if (products == null) //null check
            {
                Console.WriteLine("Could not load product catalog.");
                return;
            }

            while (true) // display the catalog to the user
            {
                Console.Clear();

                Console.WriteLine("PRODUCT CATALOG");
                Console.WriteLine("---------------");

                foreach (var product in products)
                {
                    Console.WriteLine($"Product: {product.Key}");
                    Console.WriteLine($"Price: {product.Value.Price} kr");
                    Console.WriteLine($"Weight: {product.Value.Weight} kg");
                    Console.WriteLine("-------------------------");
                }

                Console.WriteLine();
                Console.WriteLine("Enter the name of the product you want to add.");
                Console.WriteLine("Type 'finish' when you are done.");

                string? selection = Console.ReadLine();

                if (selection?.ToLower() == "finish")
                {
                    BuyFromShop();
                    return;
                }

                if (selection != null && products.TryGetValue(selection, out Product? selectedProduct))
                {
                    selectedProducts.Add(selectedProduct);

                    Console.WriteLine($"{selectedProduct.Name} added to your buy list.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Product not found.");
                    Console.ReadKey();
                }
            }
        }

    }
}