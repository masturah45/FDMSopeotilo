using FDMS_App.models;
namespace FDMS_App.Interfaces
{
    public interface IChefManager
    {
       
       public void CreateChef (string firstName, string lastname, string email, int pin, string chefID, string chefphoneNumber);
       public void UpdateChef (string firstName, string lastname, string email);
       public void DeleteChef (string email);
       public Chef GetChef (string email);  
       public Chef Login (string email, int pin);
    }
}