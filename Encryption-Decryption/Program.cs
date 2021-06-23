using System;

namespace Encryption_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your message:");
            string message = Console.ReadLine();
            Cypher msg = new Cypher(message);
            string encrypted = msg.Encrypt();
            Console.WriteLine($"Encrypted message: {encrypted}");
            Console.WriteLine($"Decrypted message: {msg.Decrypt()}");
        }
    }
}
