using FDMS_App.models;

namespace FDMS_App.Interfaces
{
    public interface ICustomerManager
    {
        public void CreateCustomer (string address, string phoneNumber, string firstName, string lastname, string email, int pin);
        public void UpdateCustomer (string firstName, string lastName, string phoneNumber, string email);
        public void DeleteCustomer (string email);
        public Customer GetCustomer (string email);
        public Customer Login(string email, int pin);
    }
}