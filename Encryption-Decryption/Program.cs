using System;

namespace Encryption_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {

            Cypher msg = new Cypher("Hello world. How are you guys? Cause i'm great!");

            string encrypted = msg.Encrypt();
            Console.WriteLine($"Encrypted message: {encrypted}");
            Console.WriteLine($"Decrypted message: {msg.Decrypt()}");

        }
    }
}
