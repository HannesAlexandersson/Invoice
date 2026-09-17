

namespace Invoice
{
    public class Shop
    {
        public static void BuyFromShop()
        {
            // create the list of products
            var buyList = new List<string> { };
            // the absolute path to where to store the file
            var customerBuyListFile = "C:\\Users\\s1031\\Documents\\GitHub\\Invoice";

            //fethc the product cataloge

            // add the selected products to the customerbuylist


            // save the list as a text file
            File.WriteAllLines(customerBuyListFile, buyList);
        }
    }
}