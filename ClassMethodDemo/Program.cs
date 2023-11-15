namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Customer customer = new Customer();
            customer.CustomerId = 1;
            customer.CustomerName = "Yusuf";
            customer.CustomerLastName = "Demiray";

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Merve";
            customer2.CustomerLastName = "Karatepe";

            Customer[] customers = new Customer[] {customer,customer2};
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer2);
            customerManager.Delete(customer);
            customerManager.List(customer,customer2);






        }
    }
}