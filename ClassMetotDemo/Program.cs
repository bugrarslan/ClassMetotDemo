using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.TcNo = "12345678910";
            customer.FirstName = "Buğra";
            customer.LastName = "Arslan";

            string[] customers = new string[]
            {"Tc kimlik no :" + customer.TcNo, "İsim :" + customer.FirstName,"Soyisim :" +  customer.LastName };

            foreach (var item in customers)
            {
                Console.WriteLine(item);
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.List();
            customerManager.Delete();
            Console.ReadLine();
        }
    }
}
