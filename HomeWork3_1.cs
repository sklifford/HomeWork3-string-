//Дана строка символов. Необходимо проверить, является ли эта строка палиндромом.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String S;
            Console.WriteLine("Введите строку для проверки её на палиндромность.");
            S = Console.ReadLine();
            char[] Marks = { ' ', '.', ',', '!', ':', ';', '-', '?' };
            String[] Temp = new String[S.Length];
            Temp = S.Split(Marks);
            S = String.Join(null, Temp);
            S = S.ToLower();
            Boolean Flag = false;
            for(int i = 0, j = S.Length-1; i<S.Length && j>=0; i++, j--)
            {
                if(S[i] != S[j])
                {
                    Flag = false;
                    break;
                }
                Flag = true;
            }
            if(Flag)
            {
                Console.WriteLine("Это палиндром");
            } else
            {
                Console.WriteLine("Это не палиндром");
            }
        }
    }
}
