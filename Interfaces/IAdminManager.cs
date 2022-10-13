using FDMS_App.models;
namespace FDMS_App.Interfaces
{
    public interface IAdminManager
    {
         
       public void CreateAdmin (string firstName, string lastname, string email, int pin, int adminID, string phoneNumber);
       public void UpdateAdmin (string firstName, string lastname, string email, int pin, int adminID, string phoneNumber);
       public void DeleteAdmin (string email);
       public Admin GetAdmin (string email);
       public Admin Login (string email, int pin);
    }
}