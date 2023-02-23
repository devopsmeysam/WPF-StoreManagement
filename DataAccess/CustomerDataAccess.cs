using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomerDataAccess
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public CustomerDataAccess()
        {
            ReadCustomers();
        }

        private void ReadCustomers()
        {
            Customer cust1 = new Customer()
            {
                Id = 1,
                FirstName = "David",
                LastName = "Padovani",
                PhoneNumber = 6475012345,
                Address = "LMN Leslie St, Markham, L0L 0L0",
                Membership = Membership.Platinum
            };
            Customer cust2 = new Customer()
            {
                Id = 2,
                FirstName = "Eric",
                LastName = "Padovani",
                PhoneNumber = 6475012344,
                Address = "QRS Bathurst St, Vaughan, S0S 0S0",
                Membership = Membership.Gold
            };
            Customers.Add(cust1);
            Customers.Add(cust2);
        }

        public void CreateCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            Customer temp = Customers.First(x =>  x.Id == customer.Id);
            int index = Customers.IndexOf(temp);
            Customers[index] = customer;
        }

        public void DeleteCustomer(int id)
        {
            Customer temp = Customers.First(x =>x.Id == id);
            Customers.Remove(temp);
        }

        public int GetNextId()
        {
            int index = Customers.Any() ? Customers.Max(x => x.Id) + 1 : 1;

            return index;
        }
    }
}
