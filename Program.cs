namespace Invoice;

class Program
{
    static void Main(string[] args)
    {
        var app = new MainMenu();
        app.Run();
        Console.Write("Starting the Program, Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}
