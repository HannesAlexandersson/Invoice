namespace Invoice;

class Program
{
    static void Main(string[] args)
    {
        // create the list of products
        var buyList = new List<string> { "Dewalt grinder", "Samsung worklight", "Yamaha battleaxe", "Link occarina" };
        // the absolute path to where to store the file
        var products = "C:\\Users\\s1031\\Documents\\GitHub\\Invoice";
        // save the list as a text file
        File.WriteAllLines(products, buyList);

    }
}
