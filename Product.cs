
namespace Invoice
{
    public class Product(string productid, double productPrice, double productWeight, string productName)
    {
        private string ProductId { get; set; } = productid;
        private double ProductPrice { get; set; } = productPrice;
        private double ProductWeight { get; set; } = productWeight;
        private string ProductName { get; set; } = productName;

    }
}