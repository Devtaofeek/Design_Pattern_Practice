using MiddleLayer;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Factory
{
  public static  class FactoryClass
    {
        public static Dictionary<string, CustomerBase> CustomerTypes = new Dictionary<string, CustomerBase>();

       
        public static CustomerBase Create(string customertype)
        {
            CustomerTypes.Add("lead", new Lead());
            CustomerTypes.Add("customer", new Customer());
            return CustomerTypes[customertype];
        }
    }
}
