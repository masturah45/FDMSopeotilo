namespace FDMS_App.models
{
    public class Food
    {
        public string FoodName {get; set;}
        public double FoodPrice {get; set;}
        public int FoodRefNumber {get; set;}

        public Food (string foodName, double foodPrice, int foodRefNumber)
        {
            FoodName = foodName;
            FoodPrice = foodPrice;
            FoodRefNumber = foodRefNumber;
        }
    }
}