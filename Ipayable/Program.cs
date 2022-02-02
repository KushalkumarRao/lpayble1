using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipayable
{
    class Program
    {
        static void Main(string[] args)
        {

            var payableobjects = new List<IPayable>() { new Invoice("01234","seat",2,2334.2M),
                                                     new Invoice("56788","tire",4,233.45M) ,
                                                      new SalariedEmployee("kushal","rao","1234567654",456.65M),
                                                       new SalariedEmployee("kush","kum","123465432",7634.47M)};

            Console.WriteLine("Invoice and Employee processed ploymorphically :\n");
            foreach (var payable in payableobjects)
            {
                Console.WriteLine($"{payable}");
                Console.WriteLine($"payment due :{payable.GetPaymentAmount():c}\n");
            }
            Console.ReadKey();


        }
        
    }
}
