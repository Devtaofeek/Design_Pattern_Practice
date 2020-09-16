using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Practice.StructuralPattern.DecoratorPattern
{
    public class EncryptedCloudStream : IStream
    {
        private IStream stream;
        public EncryptedCloudStream(IStream stream)
        {
            this.stream = stream;
        }
        public void Write(string data)
        {
            var encrypted = Encryptmeth(data);
            this.stream.Write(encrypted);
        }

        public string Encryptmeth(string data)
        {
            return "encrypted mother fucking data";
        }
    }
}
