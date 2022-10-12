namespace FDMS_App.models
{
    public class DeliveryMan : User
    {
        public string BikePlateNumber {get; set;}
        public string DeliveryManNumber {get; set;}

        public DeliveryMan(string bikePlateNumber, string deliveryManNumber,string firstName, string lastname, string email, int pin) : base (firstName, lastname, email, pin)
        {
            BikePlateNumber = bikePlateNumber;
            DeliveryManNumber = deliveryManNumber;
        }
    }
}