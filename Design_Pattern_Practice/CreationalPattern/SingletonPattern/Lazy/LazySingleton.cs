using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Practice.CreationalPattern.SingletonPattern.Lazy
{
  public  class LazySingleton:Confirmworking
    {
        private static readonly Lazy<LazySingleton> instance = new Lazy<LazySingleton>(()=> new LazySingleton());

        private LazySingleton()
        {

        }
        public static LazySingleton getInstance()
        {
            
            return instance.Value;
        }
        public override void working()
        {
            Console.WriteLine("working");
        }
        public override void workingfromabstracr()
        {
            base.workingfromabstracr();
        }
    }
}
