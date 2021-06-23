using System;
using System.Collections.Generic;
using System.Text;
    
namespace Encryption_Decryption
{
    class Cypher : IEncryptAndDecrypt
    {
        private const int rows = 4;
        public string Decrypt(string EncryptedMessage)
        {
            int cols = (int)Math.Ceiling((double)EncryptedMessage.Length / rows);

            char[,] initArr = new char[rows, cols];
            string resStr = new string("");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i * cols + j >= EncryptedMessage.Length) break;
                    initArr[i, j] = EncryptedMessage[i * cols + j];
                }
            }   //  Creating 2D-array from given string

            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    resStr += initArr[j, i];
            //  Transposing 2D-array and writing it into a string

            return resStr;
        }

        public string Encrypt(string message)
        {
            int cols = (int)Math.Ceiling((double)message.Length / rows);

            char[,] initArr = new char[cols, rows];
            string resStr = new string("");

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (i * rows + j >= message.Length) break;
                    initArr[i, j] = message[i * rows + j];
                }
            }   //  Creating 2D-array from given string

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    resStr += initArr[j, i];   
                //  Transposing 2D-array and writing it into a string

            return resStr;
        }
    }
}
