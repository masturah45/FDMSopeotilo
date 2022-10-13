using System;
using System.Collections.Generic;
using FDMS_App.Interfaces;
using FDMS_App.models;
namespace FDMS_App.Implementation
{
    public class FoodManager : IFoodManager
    {
        public static List<Food> listOfFoods = new List<Food>();

        public void CreateFood(string foodName, double foodPrice)
        {
            Random rand = new Random();
            int foodRefNumber = rand.Next(100, 999);
            Food food = new Food( foodRefNumber, foodName, foodPrice);
            listOfFoods.Add(food);
            Console.WriteLine($"{foodName} created successfully");
        }

        public void DeleteFood(int foodRefNumber)
        {
            foreach (var item in listOfFoods)
            {
                if (item.FoodRefNumber == foodRefNumber)
                {
                    listOfFoods.Remove(item);
                    break;
                }
            }
            Console.WriteLine("removed successfully");
        }

        public Food GetFood(string foodName)
        {
            foreach (var item in listOfFoods)
            {
                if (item.FoodName == foodName)
                {
                   return item;
                }
            }
            return null;
        }

        public Food GetFood(int foodRefNumber)
        {
            foreach (var item in listOfFoods)
            {
                if (item.FoodRefNumber == foodRefNumber)
                {
                    return item;
                }
            }
            return null;
        }


        public void UpdateFood(string foodName, double foodPrice, string newFoodName, double newFoodPrice)
        {
            Food foodToUpdate = GetFood(foodName);
            if (foodToUpdate != null)
            {
                foodToUpdate.FoodName = newFoodName;
                foodToUpdate.FoodPrice = newFoodPrice;
                Console.WriteLine("food update successfully");
            }
            else
            {
                Console.WriteLine("food not found");
            }
        }
    }
}