using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipayable
{
     public abstract class Employee:IPayable
    {
        public string Firstname { get; }

        public string Lastname { get; }
        public string Socialsecuritynumber { get; }
        public Employee(string firtstname,string lastname,string socialsecuritynumber)
        {
            Firstname = firtstname;
            Lastname = lastname;
            Socialsecuritynumber = socialsecuritynumber;
            
        }
        public override string ToString() => $"{Firstname}{Lastname}\n" + $"socialsecuritynumber:{Socialsecuritynumber}";
        public abstract decimal Earnings();
        public decimal GetPaymentAmount() => Earnings(); 


    }
}
