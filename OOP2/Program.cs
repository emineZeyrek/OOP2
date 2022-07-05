namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // gerçek müşteri
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerId = 1;
            customer1.CustomerNumber = 12345;
            customer1.CustomerName = "Emine";
            customer1.CustomerLastName = "Zeyrek";
            customer1.TcNo = "111111111";

            //tüzel müşteri
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.CustomerId = 1;
            customer2.CustomerNumber = 12345;
            customer2.CompanyName = "XYZ";
            customer2.TaxNumber = "123456";


            Customer customer3 = new IndividualCustomer();//müşteri class ı hem gerçek hem de tüzel müşterinin referansını tutuyor
            Customer customer4 = new CorporateCustomer();


            CustomerManager customerManager=new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2); 


        }
    }
}