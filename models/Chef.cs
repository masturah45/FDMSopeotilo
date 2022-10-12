namespace FDMS_App.models
{
    public class Chef : User
    {
        public string ChefCompanyID {get; set;}
        public string ChefPhoneNumber {get; set;}
        
        public Chef(string chefCompanyID, string ChefphoneNumber,string firstName, string lastname, string email, int pin) : base (firstName, lastname, email, pin)
        {
            ChefCompanyID = chefCompanyID;
            ChefPhoneNumber = chefCompanyID;
        }

    }
}