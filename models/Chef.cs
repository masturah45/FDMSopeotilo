namespace FDMS_App.models
{
    public class Chef : User
    {
        public string ChefID {get; set;}
        public string ChefPhoneNumber {get; set;}
        
        public Chef(string chefID, string chefphoneNumber,string firstName, string lastname, string email, int pin) : base (firstName, lastname, email, pin)
        {
            ChefID = chefID;
            ChefPhoneNumber = chefphoneNumber;
        }

    }
}