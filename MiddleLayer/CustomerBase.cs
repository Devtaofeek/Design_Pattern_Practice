using System;
using System.Collections.Generic;
using System.Text;

namespace MiddleLayer
{
   public class CustomerBase
    {

        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        public virtual void Validate()
        {
           // validation rules
        }
    }

    public class Customer:CustomerBase
    {
        public override void Validate()
        {
            //validation rules 
        }
    }

    public class Lead:CustomerBase
    {
        public override void Validate()
        {
            base.Validate();
        }
    }
}
