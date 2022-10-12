namespace FDMS_App.Interfaces
{
    public interface ICustomerManager
    {
        public bool ICreateCustomer (string customerName);
        public void IUpdateCustomer (string customerFirstName, string customerLastName, string customerPhoneNumber);
        public void IDeleteCustomer ();
        public void IGetCustomer (string customerEmail);
    }
}