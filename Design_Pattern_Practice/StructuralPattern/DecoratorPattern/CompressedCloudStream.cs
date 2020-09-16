using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Practice.StructuralPattern.DecoratorPattern
{
    public class CompressedCloudStream : IStream
    {
        private IStream stream;
       
        public CompressedCloudStream(IStream stream)
        {
            this.stream = stream;
        }
        public void Write(string data)
        {
            var compresseddata = compress(data);
            stream.Write(compresseddata);
        }

        private string compress(string data)
        {
            return "strong compressed";
        }

    }
}
