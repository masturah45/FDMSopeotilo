namespace FDMS_App.models
{
    public class Admin : User
    {
        public int AdminID {get; set;}
        public string PhoneNumber {get; set;}

        public Admin(string firstName, string lastName,string email, string phoneNumber, int adminID, int pin) : base (firstName, lastName, email, pin)
        {
            AdminID = adminID;
            PhoneNumber = phoneNumber;
        }
    }
}