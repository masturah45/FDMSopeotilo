namespace FDMS_App.Interfaces
{
    public interface IFoodManager
    {
       public bool ICreateFood (string foodName, double foodPrice);
       public void IUpdateFood (string foodName, double foodPrice);
       public void IDeleteFood ();
       public void IGetFood (string foodName);
       public void IGetFood (int foodRefNumber);

    }
}