using System;
using System.Collections.Generic;
using System.Text;
    
namespace Encryption_Decryption
{
    class Cypher : IEncryptAndDecrypt
    {
        private const int dimension = 4;
        public string Decrypt(string EncryptedMessage)
        {
            throw new NotImplementedException();
        }

        public string Encrypt(string message)
        {
            int cols = (int)Math.Ceiling((double)message.Length / dimension);

            char[,] arr = new char[dimension, cols];

            string res = new string("");
            Console.WriteLine(arr.GetLength(0));

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if      (i == 0 && j != 0)            arr[i, j] = message[j*dimension];
                    else if (i != 0 && j == 0)            arr[i, j] = message[i];
                    else if (i*dimension+j < arr.Length)  arr[j, i] = message[i * dimension+j];
                    else                                  arr[i, j] = message[i+j*i+1];
                } 
            }   //  Writing message in 2D-array form (by columns)

            for (int i = 0; i < dimension; i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    res += arr[i, j];
                //  Writing 2D-array into encrypted message (by rows)
            return res;
        }
    }
}
