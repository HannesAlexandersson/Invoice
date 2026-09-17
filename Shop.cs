


namespace Invoice
{
    public class Shop
    {
        private ProductCatalog catalog = new();
        private List<Product> selectedProducts = [];
        public void BuyFromShop()
        {
            // create the list of products
            var buyList = new List<string> { };

            // map over all producs in selectedproducts list
            foreach (Product product in selectedProducts)
            {
                // and for each product add it to the buylist
                buyList.Add($"{product.ProductId},{product.Name},{product.Price},{product.Weight}");
            }

            var customerBuyListFile = "C:\\Users\\s1031\\Documents\\GitHub\\Invoice\\customer_buy_list.txt";   // the absolute path to where to store the file

            // save the list as a text file, wich simulates storing it to a db
            File.WriteAllLines(customerBuyListFile, buyList);


        }

        public void BrowseProductCataloge()
        {
            catalog.LoadProducts();

            if (catalog.Products == null) //null check
            {
                Console.WriteLine("Could not load product catalog.");
                return;
            }

            while (true) // present the catalog to the user with a selection menu for choosing what to add to the buy list
            {
                Console.Clear();

                Console.WriteLine("PRODUCT CATALOG");
                Console.WriteLine("---------------");

                var productList = catalog.Products.ToList();

                for (int i = 0; i < productList.Count; i++)
                {
                    var product = productList[i];

                    Console.WriteLine($"Id: {i + 1}");
                    Console.WriteLine($"Product: {product.Key}");
                    Console.WriteLine($"Price: {product.Value.Price} kr");
                    Console.WriteLine($"Weight: {product.Value.Weight} kg");
                    Console.WriteLine("-------------------------");
                }

                Console.WriteLine();
                Console.WriteLine("Enter the id of the product you want to add.");
                Console.WriteLine("Press 'X' when you are done.");

                string? selection = Console.ReadLine();

                if (selection?.ToLower() == "x")
                {
                    BuyFromShop(); // when user have selected 'X' we call the buy method wich will take the list with selected products and write it to file (simulate an db)
                    return;
                }
                // this is the logic for adding the selected product to the list
                if (int.TryParse(selection, out int selectedId) &&
                    selectedId >= 1 &&
                    selectedId <= productList.Count)
                {
                    Product selectedProduct = productList[selectedId - 1].Value;

                    selectedProducts.Add(selectedProduct);

                    Console.WriteLine($"{selectedProduct.Name} added to your buy list.");
                    Console.ReadKey();
                }
                else // failsafe fr invalid input from user
                {
                    Console.WriteLine("Invalid product id.");
                    Console.ReadKey();
                }
            }
        }

        public void AddProduct()
        {
            LoadCustomerBuyList();

            BrowseProductCataloge();
        }
        public void RemoveProduct()
        {
            catalog.LoadProducts(); // get the cataloge instance
            LoadCustomerBuyList(); // load the preexisting buylist

            while (true) // shows the buylist to the user with menu selection options for removing products
            {
                Console.Clear();

                Console.WriteLine("YOUR BUY LIST");
                Console.WriteLine("-------------");
                for (int i = 0; i < selectedProducts.Count; i++) // the preexisiting list
                {
                    Console.WriteLine($"{i + 1}. {selectedProducts[i].Name}");
                    Console.WriteLine($"   Price: {selectedProducts[i].Price} kr");
                    Console.WriteLine($"   Weight: {selectedProducts[i].Weight} kg");
                    Console.WriteLine("-------------------------");
                }

                Console.WriteLine();
                Console.WriteLine("Enter the ID of the product you want to remove.");
                Console.WriteLine("Press 'X' when you are done.");

                string? selection = Console.ReadLine();

                if (selection?.ToLower() == "x") // when the user is done we re save the buy list
                {
                    BuyFromShop();
                    return;
                }
                // what is selected and what isnt
                if (int.TryParse(selection, out int selectedId) &&
                    selectedId >= 1 &&
                    selectedId <= selectedProducts.Count)
                {
                    selectedProducts.RemoveAt(selectedId - 1);
                }
                else
                {
                    Console.WriteLine("Invalid product ID.");
                    Console.ReadKey();
                }
            }
        }

        public void LoadCustomerBuyList()
        {
            // look for the buy list
            string filePath =
                "C:\\Users\\s1031\\Documents\\GitHub\\Invoice\\customer_buy_list.txt";

            selectedProducts.Clear(); // clear oyt the selected products lust

            if (!File.Exists(filePath)) // if it doesnt exist then exit out
            {
                Console.WriteLine("No buy list exists!"); // tell the user they are stupid for tryint ot remove objects from a non existing list
                return;
            }

            var customerBuyList = File.ReadAllLines(filePath); // create a var of the lsist



            foreach (string line in customerBuyList) // go thorugh the buy list 
            {
                string[] data = line.Split(',');

                string productId = data[0];

                foreach (Product product in catalog.Products.Values)
                {
                    if (product.ProductId == productId)
                    {
                        selectedProducts.Add(product);
                        break;
                    }
                }
            }
        }


    }
}