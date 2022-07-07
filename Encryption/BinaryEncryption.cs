using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class BinaryEncryption: IBitEncryptDecrypt 
    {


        private string _wordsencrypt { get; set; }

        private byte[] _stringarray { get; set; }
        private string _bitencrypt { get; set; }
        
        public string Encrypt(string Words)
        {

            StringBuilder sb = new StringBuilder();
            foreach (byte b in System.Text.Encoding.Unicode.GetBytes(Words))
            {
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0')).Append(' ');    /// This method encrypts words into binary; Этот метод переводит слова в двоичный код
            }

            return _bitencrypt = sb.ToString();

        }
        
        public string Decrypt(string BinaryNumbers)
        {
            _stringarray = Enumerable.Range(0, BinaryNumbers.Length / 8).Select(i => Convert.ToByte(BinaryNumbers.Substring(i * 8, 8), 2)).ToArray();  /// This method decrypts words into binary; Этот метод переводит двоичный код в слова
            return _wordsencrypt = Encoding.UTF8.GetString(_stringarray);
        }



        public void Print()
        {
            Console.WriteLine($"Зашифрованный текст:{_bitencrypt}\n Расшифрованный текст:{_wordsencrypt}");
        }
    }
}
