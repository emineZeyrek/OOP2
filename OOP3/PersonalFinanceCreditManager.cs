﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class PersonalFinanceCreditManager : ICreditManager // ihtiyaç kredisi
    {
        public void Calculate()
        {
            //throw new NotImplementedException();

            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
