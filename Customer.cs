
namespace Invoice
{
    public class Customer(string fName, string lname, string address, string phoneN)
    {
        private string FirstName { get; set; } = fName;
        private string LastName { get; set; } = lname;
        private string Address { get; set; } = address;

        private string PhoneNumber { get; set; } = phoneN;

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetAddress()
        {
            return $"{Address}";
        }
        public string GetPhoneNumbr()
        {
            return $"{PhoneNumber}";
        }


    }
}