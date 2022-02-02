using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipayable
{
    public class SalariedEmployee : Employee
    {
        private decimal Weeklysalary;


        public SalariedEmployee(string firstname, string lastname, string socialsecuritynumber, decimal weeklysalary) : base(firstname, lastname, socialsecuritynumber)
        {
            Weeklysalary = weeklysalary;
        }
       
        public decimal WeeklySalary
        {
            get { return Weeklysalary; }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Weeklysalary)} must be >=0");
                }
                Weeklysalary = value;
            }



        }
        public override decimal Earnings() => Weeklysalary;

        public override string ToString() => $"salaried employee:{base.ToString()}\n" + $"weeklysalary:{Weeklysalary:c}";
       


    }
}
