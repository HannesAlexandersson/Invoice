namespace Invoice
{
    public class InvoiceManager
    {
        private static readonly Customer customer = new Customer("Hannes", "Alexandersson", "Munkebäcksgatan 23 h", "0790112009"); // create the customer objet
        private Invoice invoice = new(customer); // create the instance of the invoice, send the customer object to the primary constructor
        private string[] menuOptions =
  {
        "1. View invoices",
        "2. Pay",
        "3. Exit"
    };

        private int menuSelect = 0;

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                if (menuSelect == 0)
                {
                    Console.WriteLine("Invoice manager 2000");
                    Console.WriteLine("*********************");
                    Console.WriteLine("* " + menuOptions[0] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (menuSelect == 1)
                {
                    Console.WriteLine("Invoice manager 2000");
                    Console.WriteLine("*********************");
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + menuOptions[1] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (menuSelect == 2)
                {
                    Console.WriteLine("Invoice manager 2000");
                    Console.WriteLine("*********************");
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + menuOptions[2] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                }

                var keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length - 1)
                {
                    menuSelect++;
                }
                else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1)
                {
                    menuSelect--;
                }
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    switch (menuSelect)
                    {
                        case 0:
                            invoice.ViewInvoice();
                            break;
                        case 1:
                            invoice.PayInvoice();
                            break;
                        case 2:
                            Terminate();
                            break;
                        default:
                            Terminate();
                            break;

                    }
                }


            }
        }

        public static void Terminate()
        {
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
        }
    }
}