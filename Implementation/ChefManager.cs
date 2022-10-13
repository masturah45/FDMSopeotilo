using System;
using System.Collections.Generic;
using FDMS_App.Interfaces;
using FDMS_App.models;

namespace FDMS_App.Implementation
{
    public class ChefManager : IChefManager
    {
        public static List<Chef> listOfChefs = new List<Chef>();
        public void CreateChef(string firstName, string lastname, string email, int pin, string chefID, string chefphoneNumber)
        {
            Random random = new Random();
            int chf = random.Next(10,99);
            Chef chef = new Chef(firstName, lastname, email,  chefID, chefphoneNumber, pin);
            listOfChefs.Add(chef);
            Console.WriteLine("created successfully");
        }

        public void DeleteChef(string email)
        {
            foreach (var item in listOfChefs)
            {
                if (item.Email == email)
                {
                    listOfChefs.Remove(item);
                    break;
                }
            }
            Console.WriteLine("deleted successfully");
        }

        public Chef GetChef(string email)
        {
            foreach (var item in listOfChefs)
            {
                if (item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }

        public Chef Login(string email, int pin)
        {
            foreach (var item in listOfChefs)
            {
                if (item.Email == email && item.Pin == pin )
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateChef(string firstName, string lastname, string email)
        {
            Chef chefToUpdate = GetChef(email);
            if (chefToUpdate != null)
            {
                chefToUpdate.FirstName = firstName;
                chefToUpdate.LastName = lastname;
                Console.WriteLine("chef updated successfully");
            }
            else
            {
                Console.WriteLine("chef not found");
            }
        }
    }
}