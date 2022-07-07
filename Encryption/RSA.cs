using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    public class RSA
    {
        private string _alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";

        private string _key = "Далекий";
     
        private string _words = "ДЗРОЮНУОГООЮВЛЕНАОГНММАООЮКП";

        private string[] _wordschar;

        public List<string> _wordslist = new List<string>();
                                                                                                        
        List<string> BreakLines()
        {
            for (int i = 0; i < _words.Length - 1; )
            {
                _wordslist.Add(_words.Substring(i, _key.Length));               ///Метод для разбивки зашифрованного слова, которое зависит от длины ключа(_words.Length / _key.Length)
                i += _key.Length;
            }
            return _wordslist;
        }
        
        public void Print()
        {
            
            
        }


        


    }
}
