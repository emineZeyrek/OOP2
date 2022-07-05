namespace OOP3
{
    internal class Program // her kredi türü içn bir class
    {
        static void Main(string[] args)
        {
          //PersonalFinanceCreditManager personalFinanceCreditManager= new PersonalFinanceCreditManager();
          //TransportCreditManager transportCreditManager= new TransportCreditManager();  
          //HousingLoanManager housingLoanManager = new HousingLoanManager();


            //interface kullanımı da aynı sonucu verir

            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            //personalFinanceCreditManager.Calculate();

            ICreditManager transportCreditManager = new TransportCreditManager();
            

            ICreditManager housingLoanManager = new HousingLoanManager();
            

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService= new FileLoggerService();                                                        

            //List<ILoggerService> loggers = new List<ILoggerService> { databaseLoggerService,fileLoggerService};
            //logların tutulması


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(personalFinanceCreditManager,new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService()  });// hangisi sisteme girilirse onu hesaplar


            //applicationManager.MakeAnApplication(transportCreditManager);
            //applicationManager.MakeAnApplication(housingLoanManager);


            List<ICreditManager> credits =new List<ICreditManager>() { };

            applicationManager.KrediOnBilgilendirmesiYap(credits);


        }
    }
}