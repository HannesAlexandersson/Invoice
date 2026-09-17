
namespace Invoice
{
    class Invoice
    {
        double Sum = CalculatePayment();
        string DeliveryAddress;
        string CustomerAddress;
        string InvoiceId;
        List<Product> Products = [];

        // PUBLIC METHODS
        public static void PayInvoice()
        {
            CalculatePayment();
            CompletePayment();
        }

        public static void ViewInvoice()
        {

        }
        public static void Calculations()
        {
            // do calculations
        }

        // PRIVATE METHODS
        private static double CalculatePayment()
        {
            // internal logic add toghether all products in Products and return the total sum
            return 0.0;
        }

        private static void CompletePayment()
        {
            // simulate paying the invoice: print pay and then remoce the products from the list of products. 
        }


    }
}