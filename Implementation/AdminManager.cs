using System;
using System.Collections.Generic;
using FDMS_App.Interfaces;
using FDMS_App.models;

namespace FDMS_App.Implementation
{
    public class AdminManager : IAdminManager
    {
        public static List<Admin> listOfAdmins = new List<Admin>();

        public void CreateAdmin(string firstName, string lastname, string email, int pin, int adminID,  string phoneNumber)
        {
            Random rand = new Random();
            int adm = rand.Next(10,99);
            Admin admin = new Admin(firstName, lastname, email, phoneNumber, adminID, pin);
            listOfAdmins.Add(admin);
            Console.WriteLine("created successful");
        }
        

        public void DeleteAdmin(string email)
        {
            foreach (var item in listOfAdmins)
            {
                if (item.Email == email)
                {
                    listOfAdmins.Remove(item);
                    break;
                }
            }
            Console.WriteLine("deleted successfully");
        }

        public Admin GetAdmin(string email)
        {
            foreach (var item in listOfAdmins)
            {
                if (item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }

        public Admin Login(string email, int pin)
        {
            foreach (var item in listOfAdmins)
            {
                if (item.Email == email && item.Pin == pin )
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateAdmin(string firstName, string lastname, string email, int pin, int adminID, string phoneNumber)
        {
            Admin adminToUpdate = GetAdmin(email);
            if (adminToUpdate != null)
            {
                adminToUpdate.FirstName = firstName;
                adminToUpdate.LastName = lastname;
                adminToUpdate.Email = email;
                adminToUpdate.Pin = pin;
                adminToUpdate.AdminID = adminID;
                adminToUpdate.PhoneNumber = phoneNumber;
                Console.WriteLine("admin updated successfully");
            }

            else
            {
                Console.WriteLine("admin not found");
            }
        }

    
    }
}