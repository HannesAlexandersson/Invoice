namespace Invoice
{
    public class InvoiceManager
    {
        private string[] menuOptions =
  {
        "1. View invoices",
        "2. Pay",
        "3. Calculations",
        "4. Add products",
        "5. Remove products",
        "6. Exit"
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
                    Console.WriteLine(menuOptions[3]);
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
                    Console.WriteLine(menuOptions[3]);
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
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (menuSelect == 3)
                {
                    Console.WriteLine("Invoice manager 2000");
                    Console.WriteLine("*********************");
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine("* " + menuOptions[3] + " *");
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (menuSelect == 4)
                {
                    Console.WriteLine("Invoice manager 2000");
                    Console.WriteLine("*********************");
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (menuSelect == 5)
                {
                    Console.WriteLine("Invoice manager 2000");
                    Console.WriteLine("*********************");
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (menuSelect == 6)
                {
                    Console.WriteLine("Invoice manager 2000");
                    Console.WriteLine("*********************");
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine("- - - - - - - - - - -");
                }
                else if (menuSelect == 7)
                {
                    Console.WriteLine("Invoice manager 2000");
                    Console.WriteLine("*********************");
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine("- - - - - - - - - - -");
                    Console.WriteLine(menuOptions[3]);
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
                            Invoice.ViewInvoice();
                            break;
                        case 1:
                            Invoice.PayInvoice();
                            break;
                        case 2:
                            Invoice.Calculations();
                            break;
                        case 3:
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