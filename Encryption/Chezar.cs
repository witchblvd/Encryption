using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    public class Chezar : IChezarEncryptDecrypt
    {
         private int _numberalphabet { get; set; }

         private int offsetletter { get; set; }

         private string result { get; set; }

         private string words { get; set; }

        private char[] charwords { get; set; }

         private char[] _alphabet = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

        public string Encrypt(string Words,int Number, int OffSetLetter)
        {
            charwords = Words.ToCharArray();

            for (int i = 0; i < charwords.Length; i++)
            {
                for (int j = 0; j < _alphabet.Length; j++)
                {
                    if (charwords[i] == _alphabet[j])
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
                charwords[i] = _alphabet[OffSetLetter]; // Меняем букву
            }
            return result = charwords.ToString();
        }

        public string Decrypt(string Words, int Number, int OffSetLetter)
        {
            charwords = Words.ToCharArray();

            for (int i = 0; i < charwords.Length; i++)
            {
                for (int j = 0; j < _alphabet.Length; j++)
                {
                    if (charwords[i] == _alphabet[j])
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
                charwords[i] = _alphabet[OffSetLetter]; // Меняем букву
            }
            return result = charwords.ToString();
        }

        public void Print()
        {
            Encrypt("тест",20,2);
            Console.WriteLine(result);
        }
    }
}
