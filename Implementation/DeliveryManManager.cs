using System;
using System.Collections.Generic;
using FDMS_App.Interfaces;
using FDMS_App.models;

namespace FDMS_App.Implementation
{
    public class DeliveryManManager : IDeliveryManManager
    {    
        public static List<DeliveryMan> listOfDeliveryMen = new List<DeliveryMan>();
        public void CreateDeliveryMan(string bikePlateNumber, string firstName, string lastName, string email, string phoneNumber, int pin)
        {    
            Random random = new Random();
            int custID = random.Next(10, 99);
            DeliveryMan deliveryman = new DeliveryMan(bikePlateNumber, firstName, lastName, email, phoneNumber, pin);
            listOfDeliveryMen.Add(deliveryman);
            Console.WriteLine("created successfully");
        }

        public void DeleteDeliveryMan(string email)
        {    
            foreach (var item in listOfDeliveryMen)
            {
                if (item.Email == email)
                {
                    listOfDeliveryMen.Remove(item);
                    break;
                }
            }
            Console.WriteLine("deleted successfully");
        }

        public DeliveryMan GetDeliveryMan(string email)
        {    
            foreach (var item in listOfDeliveryMen)
            {
                if (item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }

        public DeliveryMan Login(string email, int pin)
        {    
            foreach (var item in listOfDeliveryMen)
            {
                if (item.Email == email && item.Pin == pin )
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateDeliveryMan(string firstName, string lastName, string phoneNumber, string email)
        {    
            DeliveryMan deliveryManToUpdate = GetDeliveryMan(email);
            if (deliveryManToUpdate != null)
            {
                deliveryManToUpdate.FirstName = firstName;
                deliveryManToUpdate.LastName = lastName;
                deliveryManToUpdate.PhoneNumber = phoneNumber;
                Console.WriteLine("deliveryman updated successfully");
            }
            else
            {
                Console.WriteLine("deliveryman not found");
            }
        }
    }
}