
using System.Security.Cryptography.X509Certificates;

namespace Invoice
{
    public class MainMenu
    {
        private Shop shop = new Shop(); // create an shop object so we can use its methods
        private string[] menuOptions =
    {
        "1. Browse products",
        "2. Add products",
        "3. Remove products",
        "4. Manage Invoice",
        "5. Exit"
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
                    Console.WriteLine("Catalog order 2000");
                    Console.WriteLine("*********************");
                    Console.WriteLine("* " + menuOptions[0] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (menuSelect == 1)
                {
                    Console.WriteLine("Catalog order 2000");
                    Console.WriteLine("*********************");
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + menuOptions[1] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (menuSelect == 2)
                {
                    Console.WriteLine("Catalog order 2000");
                    Console.WriteLine("*********************");
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + menuOptions[2] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (menuSelect == 3)
                {
                    Console.WriteLine("Catalog order 2000");
                    Console.WriteLine("*********************");
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + menuOptions[3] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (menuSelect == 4)
                {
                    Console.WriteLine("Catalog order 2000");
                    Console.WriteLine("*********************");
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + menuOptions[4] + " *");
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
                            shop.BrowseProductCataloge();
                            break;
                        case 1:
                            shop.AddProduct();
                            break;
                        case 2:
                            shop.RemoveProduct();
                            break;
                        case 3:
                            InvoiceManager invoiceManager = new();
                            invoiceManager.Run();
                            break;
                        case 4:
                            Terminate();
                            break;
                        default:
                            Terminate();
                            break;
                    }
                }
            }
        }

        public void Terminate()
        {
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
        }
    }
}