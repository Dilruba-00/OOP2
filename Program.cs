using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndiviualCustomer customer1 = new IndiviualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Dilruba";
            customer1.Surname = "Tunçez";
            customer1.TcNo = "12345678910";


            //Kodlama.io
            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CustomerNo = "Kodlama.io";
            customer2.Taxno = "1234567890";

            //Gerçek müşteri - Tüzel Müşteri

            Customer customer3 = new IndiviualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
