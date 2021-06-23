using System;

namespace Encryption_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Cypher msg = new Cypher();
            
            Console.WriteLine($"Encrypted message: {msg.Encrypt("Hello world")}");
        }
    }
}
