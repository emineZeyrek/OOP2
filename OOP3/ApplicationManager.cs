using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager// başvuru manager
    {
        public void MakeAnApplication(ICreditManager creditManager,List <ILoggerService >loggerServices)//parametreyi almazsak hatalı olur
        {
            //başvuran bilgilerini değerlendirme

            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();


            }
        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)//krediler listesi
        {
            foreach (var credit in credits)
            {
                credit.Calculate();//listedeki her bir kredinin hesaplamasını yap

            }


        }
    }
}
