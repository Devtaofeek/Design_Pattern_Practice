using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Practice.CreationalPattern.SingletonPattern.Eager
{
  public  class EagerSingleton
    {

        private static EagerSingleton instance = new EagerSingleton();

        // a private constructor is created so that the instance of this class will not be created for anywhere except
        private EagerSingleton()
        {

        }

        public static EagerSingleton getInstance()
        {
            return instance;
        }

      public  void confirm()
        {
            Console.WriteLine("working");
            Console.ReadLine();
        }
    }
}
