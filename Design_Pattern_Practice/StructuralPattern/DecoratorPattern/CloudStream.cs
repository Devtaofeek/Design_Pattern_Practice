using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Practice.StructuralPattern.DecoratorPattern
{
    public class CloudStream : IStream
    {
        public void Write(string data)
        {
            Console.Write("writing the fucking data to stream");
        }
    }
}
