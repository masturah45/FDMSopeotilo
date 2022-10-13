namespace FDMS_App.models
{
    public class Food
    {
         public int FoodRefNumber {get; set;}
        public string FoodName {get; set;}
        public double FoodPrice {get; set;}

        public Food ( int foodRefNumber, string foodName, double foodPrice)
        {
            FoodRefNumber = foodRefNumber;
            FoodName = foodName;
            FoodPrice = foodPrice;
        }
    }
}