using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Practice
{
  public abstract  class Confirmworking
    {
        public abstract  void working();

        public virtual void workingfromabstracr()
        {
            Console.WriteLine("Woking from outside");
        }
        
    }
}
