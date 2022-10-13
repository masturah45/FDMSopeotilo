using FDMS_App.models;

namespace FDMS_App.Interfaces
{
    public interface IDeliveryManManager
    {     
        public void CreateDeliveryMan( string bikePlateNumber, string firstName, string lastName, string email, string phoneNumber, int pin);
         public void UpdateDeliveryMan( string firstName, string lastName, string phoneNumber, string email);
         public void DeleteDeliveryMan(string email);
         public DeliveryMan GetDeliveryMan(string email);
         public DeliveryMan Login(string email, int pin);
    }
}