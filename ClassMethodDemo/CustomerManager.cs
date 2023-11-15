using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer) 
        {
            Console.WriteLine("Müşteri Eklendi : " + customer.CustomerName);
        }
        public void Delete(Customer customer) 
        {
            Console.WriteLine("Müşteri Silindi : " + customer.CustomerName);
        }
        public void List(params Customer[]  customers) 
        {
            Console.WriteLine("Müşteriler Listelendi");
            Console.WriteLine("------------------------");
            foreach (Customer customer in customers) 
            {
                Console.WriteLine( customer.CustomerName);
            }
            
            
        }



    }
}
