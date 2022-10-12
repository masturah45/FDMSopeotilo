namespace FDMS_App.models
{
    public class User
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public int Pin {get; set;}

        public User(string firstName, string lastname, string email, int pin)
        {
            FirstName = firstName;
            LastName = lastname;
            Email = email;
            Pin = pin;
        }    

    }    
    
}