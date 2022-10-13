using System;
using System.Collections.Generic;
using FDMS_App.Interfaces;
using FDMS_App.models;

namespace FDMS_App.Implementation
{
    public class CustomerManager : ICustomerManager
    {
        public static List<Customer> listOfCustomers = new List<Customer>();
        public void CreateCustomer(string address, string phoneNumber, string firstName, string lastname, string email, int pin)
        {
            Random random = new Random();
            int custID = random.Next(10, 99);
            Customer customer = new Customer(address, phoneNumber, firstName, lastname, email, pin);
            listOfCustomers.Add(customer);
            Console.WriteLine("created successfully");
        }

        public void DeleteCustomer(string email)
        {
            foreach (var item in listOfCustomers)
            {
                if (item.Email == email)
                {
                    listOfCustomers.Remove(item);
                    break;
                }
            }
            Console.WriteLine("deleted successfully");
        }

        public Customer GetCustomer(string email)
        {
            
            foreach (var item in listOfCustomers)
            {
                if (item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }

        public Customer Login(string email, int pin)
        {    
            foreach (var item in listOfCustomers)
            {
                if (item.Email == email && item.Pin == pin )
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateCustomer(string firstName, string lastName, string phoneNumber, string email)
        {
            Customer customerToUpdate = GetCustomer(email);
            if (customerToUpdate != null)
            {
                customerToUpdate.FirstName = firstName;
                customerToUpdate.LastName = lastName;
                customerToUpdate.PhoneNumber = phoneNumber;
                Console.WriteLine("Customer updated successfully");
            }
            else
            {
                Console.WriteLine("customer not found");
            }
        }
    }
}