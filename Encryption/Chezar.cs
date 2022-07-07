using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    public class Chezar : IChezarEncryptDecrypt
    {
         private string _result { get; set; }

         private char[] _charwords { get; set; }

         private char[] _alphabet = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

        public string Encrypt(string Words,int Number, int OffSetLetter)
        {
            _charwords = Words.ToCharArray();

            for (int i = 0; i < _charwords.Length; i++)
            {
                for (int j = 0; j < _alphabet.Length; j++)
                {
                    if (_charwords[i] == _alphabet[j])
                    {
                        break;
                    }
                    if (j != 33) // Если j равно 33, значит символ не из алфавита
                    {
                        Number = j; // Индекс буквы
                        OffSetLetter = Number + 3; // Делаем смещение

                        // Проверяем, чтобы не вышли за пределы алфавита
                        if (OffSetLetter > 32)
                        {
                            OffSetLetter = OffSetLetter - 33;
                        }

                        
                    }

                }
                _charwords[i] = _alphabet[OffSetLetter]; // Меняем букву
            }
            return _result = _charwords.ToString();
        }

        public string Decrypt(string Words, int Number, int OffSetLetter)
        {
            _charwords = Words.ToCharArray();

            for (int i = 0; i < _charwords.Length; i++)
            {
                for (int j = 0; j < _alphabet.Length; j++)
                {
                    if (_charwords[i] == _alphabet[j])
                    {
                        break;
                    }
                    if (j != 33) // Если j равно 33, значит символ не из алфавита
                    {
                        Number = j; // Индекс буквы
                        OffSetLetter = Number - 3; // Делаем смещение

                        // Проверяем, чтобы не вышли за пределы алфавита
                        if (OffSetLetter > 32)
                        {
                            OffSetLetter = OffSetLetter - 33;
                        }


                    }

                }
                _charwords[i] = _alphabet[OffSetLetter]; // Меняем букву
            }
            return _result = _charwords.ToString();
        }

        public void Print()
        {
            Encrypt("тест",20,2);
            Console.WriteLine(_result);
        }
    }
}
