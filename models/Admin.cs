namespace FDMS_App.models
{
    public class Admin : User
    {
        public string CompanyID {get; set;}
        public string PhoneNumber {get; set;}

        public Admin(string companyID, string phoneNumber,string firstName, string lastname, string email, int pin) : base (firstName, lastname, email, pin)
        {
            CompanyID = companyID;
            PhoneNumber = phoneNumber;
        }
    }
}