using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class HousingLoanManager : ICreditManager // konut kredisi
    {
        public void Calculate()
        {
            //  throw new NotImplementedException();

            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
