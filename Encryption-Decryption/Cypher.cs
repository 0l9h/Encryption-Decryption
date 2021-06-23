using System;
using System.Collections.Generic;
using System.Text;
    
namespace Encryption_Decryption
{
    class Cypher : IEncryptAndDecrypt
    {
        private readonly int _rows;
        private string _message;
        private string _encrypted;
        public Cypher(string message)
        {
            _message = message;
            Random r = new Random();
            _rows = r.Next(1, _message.Length / 2);
        }

        public string Decrypt()
        {
            int cols = (int)Math.Ceiling((double)_encrypted.Length / _rows);

            char[,] initArr = new char[_rows, cols];
            string resStr = new string("");

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i * cols + j >= _encrypted.Length) break;
                    initArr[i, j] = _encrypted[i * cols + j];
                }
            }   //  Creating 2D-array from given string

            for (int i = 0; i < cols; i++)
                for (int j = 0; j < _rows; j++)
                    resStr += initArr[j, i];
            //  Transposing 2D-array and writing it into a string

            return resStr;
        }

        public string Encrypt()
        {
            int cols = (int)Math.Ceiling((double)_message.Length / _rows);

            char[,] initArr = new char[cols, _rows];

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < _rows; j++)
                {
                    if (i * _rows + j >= _message.Length) break;
                    initArr[i, j] = _message[i * _rows + j];
                }
            }   //  Creating 2D-array from given string

            for (int i = 0; i < _rows; i++)
                for (int j = 0; j < cols; j++)
                    _encrypted += initArr[j, i];   
                //  Transposing 2D-array and writing it into a string

            return _encrypted;
        }
    }
}
