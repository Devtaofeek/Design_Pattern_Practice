using Design_Pattern_Practice.CreationalPattern.SingletonPattern.Eager;
using Design_Pattern_Practice.CreationalPattern.SingletonPattern.Lazy;
using Design_Pattern_Practice.StructuralPattern.DecoratorPattern;
using Factory;
using System;

namespace Design_Pattern_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreEncryptedCredentials( new CompressedCloudStream( new EncryptedCloudStream(new CloudStream())));
        }

        public static void StoreEncryptedCredentials(IStream stream)
        {
            stream.Write("123456");
        }
    }
}
