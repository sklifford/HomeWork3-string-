//Написать программу, подсчитывающую количество слов, гласных и согласных букв в строке, введёной пользователем.
//Дополнительно выводить количество знаков пунктуации, цифр и др. символов.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Vowels = {'а', 'е', 'ё', 'и', 'о', 'у', 'э', 'ю', 'я', 'ы' };
            char[] Consonants = { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ' };
            char[] Punctuation = { ' ', '.', ',', '-', '!', '?', ':', ';', '(', ')', '\"' };
            char[] Numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] OtherSymbols = { 'ь', 'ъ', '№', '#', '+', '=', '%', '$', '*', '/', '\\', '&', '@' };
            int TotalSymbols = 0;
            int TotalWords = 0;
            int TotalVowels = 0;
            int TotalCons = 0;
            int TotalPunct = 0;
            int TotalDigit = 0;
            int TotalOther = 0;
            Console.WriteLine("Введите строку для анализа:");
            String S = Console.ReadLine();
            TotalSymbols = S.Length;
            S = S.ToLower();
            for(int i = 0; i < S.Length; i++)
            {
                //----------------Всего символов-----------------------
                if(S[i] == ' ')
                {
                    TotalSymbols--;
                }
                //-----------------------------------------------------
                //----------------Всего знаков пунктуации--------------
                for (int j = 1; j < Punctuation.Length; j++)
                {
                    if (S[i] == Punctuation[j])
                    {
                        TotalPunct++;
                    }
                }
                //-----------------------------------------------------
                //--------------Всего гласных--------------------------
                for(int j = 0; j < Vowels.Length; j++)
                {
                    if(S[i] == Vowels[j])
                    {
                        TotalVowels++;
                    }
                }
                //-----------------------------------------------------
                //-----------Всего согласных---------------------------
                for(int j = 0; j < Consonants.Length; j++)
                {
                    if(S[i] == Consonants[j])
                    {
                        TotalCons++;
                    }
                }
                //-----------------------------------------------------
                //----------Всего цифр---------------------------------
                for(int j = 0; j < Numbers.Length; j++)
                {
                    if(S[i] == Numbers[j])
                    {
                        TotalDigit++;
                    }
                }
                //-----------------------------------------------------
                //----------Всего других символов----------------------
                for(int j = 0; j < OtherSymbols.Length; j++)
                {
                    if(S[i] == OtherSymbols[j])
                    {
                        TotalOther++;
                    }
                }
                //-----------------------------------------------------
                //------------Всего слов-------------------------------
                if (S[i] == ' ')
                {
                    if(i > 0 && (S[i - 1] >= '0' && S[i - 1] <= '9'))
                    {
                        continue;
                    } else
                    {
                        TotalWords++;
                    }
                }
                //-----------------------------------------------------
            }
            if (TotalWords > 0)
            {
                TotalWords++;
            }
            Console.WriteLine("Всего символов - {0}, из них:", TotalSymbols);
            Console.WriteLine("Слов - {0}", TotalWords);
            Console.WriteLine("Гласных - {0}", TotalVowels);
            Console.WriteLine("Согласных - {0}", TotalCons);
            Console.WriteLine("Знаков пунктуации - {0}", TotalPunct);
            Console.WriteLine("Цифр - {0}", TotalDigit);
            Console.WriteLine("Др. символов - {0}", TotalOther);
        }
    }
}
