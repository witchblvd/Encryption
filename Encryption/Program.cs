using System.Text;
using System.Text.Encodings;
using System.Linq;
using System.Collections.Generic;

namespace Encryption;
internal class Program
{

    
    static void Main()
    {
        RSA1 rsa1 = new RSA1();
        rsa1.SortAlphabetKey();
        rsa1.Print();
     
    }
}