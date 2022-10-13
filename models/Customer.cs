namespace FDMS_App.models
{
    public class Customer : User
    {
        public string Address {get; set;}
        public string PhoneNumber {get; set;}
        public double Wallet {get; set;}

        public Customer(string address, string phoneNumber, string firstName, string lastname, string email, int pin): base (firstName, lastname, email, pin)
        {
            Address = address;
            PhoneNumber = phoneNumber;
            // Wallet = wallet;
        }

    }
}