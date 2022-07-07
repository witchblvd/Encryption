using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    internal interface IEncryptDecrypt
    {
        public string Encrypt(string Words);
        public string Decrypt(string Decrypt);
        public void Print();
    }
}
