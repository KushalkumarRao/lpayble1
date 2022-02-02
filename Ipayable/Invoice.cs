using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipayable
{
   public  class Invoice:IPayable
    {
        public string Partnumber { get; }
        public string partDescription { get; }
        private int Quantity;
        private decimal priceperItem;

        public Invoice(string partnumber,string partdescription,int quantity,decimal priceperitem)
        {
            Partnumber = partnumber;
            partDescription = partdescription;
            Quantity = quantity;
            priceperItem = priceperitem;



        }
        public int quantity
        {
            get { return Quantity; }

            set
            {
                if (value< 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(quantity)} must be >=0");
                }
                quantity = value;
            }
        }
        public decimal pricePerItem
        {
            get { return priceperItem; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(priceperItem)} must be >=0");

                }
                priceperItem = value;
            }
        }
        public override string ToString() => $"invoice:\npart number:{Partnumber} ({partDescription})\n" + $"quantity:{Quantity}\nprice per item:{pricePerItem:c}";

        public decimal GetPaymentAmount() => Quantity * pricePerItem;
        


    }
}
