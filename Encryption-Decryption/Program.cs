using System;

namespace Encryption_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Cypher msg = new Cypher();

            string encrypted = msg.Encrypt("Hello world");
            Console.WriteLine($"Encrypted message: {encrypted}");
            Console.WriteLine($"Decrypted message: {msg.Decrypt(encrypted)}");

        }
    }
}
