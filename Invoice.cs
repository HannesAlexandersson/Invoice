
namespace Invoice
{
    class Invoice(Customer customer)
    {
        private ProductCatalog _catalog = new();
        private double Sum;
        private string InvoiceId = Guid.NewGuid().ToString();
        private readonly DateTime InvoiceDate = DateTime.Now;
        private List<Product> Products = [];
        private Customer Customer { get; } = customer;
        public void ViewInvoice()
        {
            _catalog.LoadProducts(); // load the catalog 
            string filePath = "C:\\Users\\s1031\\Documents\\GitHub\\Invoice\\customer_buy_list.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("No products found.");
                Console.ReadKey();
                return;
            }

            string[] customerBuyList = File.ReadAllLines(filePath);

            foreach (string line in customerBuyList)
            {
                string[] data = line.Split(',');
                string productId = data[0];

                foreach (Product product in _catalog.Products.Values)
                {
                    if (product.ProductId == productId)
                    {
                        Products.Add(product);
                        break;
                    }
                }
            }

            Console.Clear();

            Console.WriteLine("INVOICE");
            Console.WriteLine("================================");
            Console.WriteLine($"Invoice ID: {InvoiceId}");
            Console.WriteLine($"Date: {InvoiceDate}");
            Console.WriteLine();

            Console.WriteLine("CUSTOMER");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Name: {Customer.GetFullName()}");
            Console.WriteLine($"Address: {Customer.GetAddress()}");
            Console.WriteLine($"Phone: {Customer.GetPhoneNumbr()}");
            Console.WriteLine();

            Console.WriteLine("DELIVERY");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Address: {Customer.GetAddress()}");
            Console.WriteLine($"Planned Delivery Date: {InvoiceDate.AddDays(3.0)}");

            Console.WriteLine();

            Console.WriteLine("PRODUCTS");
            Console.WriteLine("--------------------------------");

            foreach (Product product in Products)
            {
                Console.WriteLine($"{product.Name} - {product.Price} kr");
                Sum += product.Price;
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"TOTAL: {Sum} kr");

            Console.ReadKey();
        }

        public void PayInvoice()
        {
            Console.WriteLine($"Paying invoice {InvoiceId}...");
            Console.WriteLine("Confirm payment by pressing any key....");
            Console.ReadKey();

            string filePath = "C:\\Users\\s1031\\Documents\\GitHub\\Invoice\\customer_buy_list.txt";

            File.WriteAllText(filePath, "");
        }
    }
}