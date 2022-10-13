using System;
using FDMS_App.models;
namespace FDMS_App.Interfaces
{
    public interface IFoodManager
    {
       public void CreateFood (string foodName, double foodPrice);
       public void UpdateFood (string foodName, double foodPrice, string newFoodName, double newFoodPrice );
       public void DeleteFood (int foodRefNumber);
       public Food GetFood (string foodName);
       public Food GetFood (int foodRefNumber);

    }
}