using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dig = 10001;
            int start = 0;
            int fixstart = 0;
            int end = 0;
            int fixend = 0;
            int diapazon = 0;
            string PI = piSpigot(dig);
            for (int i = 0; i < PI.Length; i++)
            {
                if (PI[i] == '9')
                {
                    if (start == 0)
                    {
                        start = i;
                    }
                    else
                    {
                        end = i;
                        if (end - start - 1 > diapazon)
                        {
                            diapazon = end - start - 1;
                            fixstart = start;
                            fixend = end;
                        }
                        start = end;
                    }
                }
            }
            Console.WriteLine("Максимальное количество цифр между девятками - {0}. Находятся они между девятками на {1}-м и {2}-м местах после запятой числа ПИ",
                                diapazon.ToString(), (fixstart - 1).ToString(), (fixend - 1).ToString());
        }
        public static String piSpigot(int n)
        {
            StringBuilder pi = new StringBuilder(n);
            int boxes = n * 10 / 3;
            int[] reminders = new int[boxes];
            for (int i = 0; i < boxes; i++)
            {
                reminders[i] = 2;
            }
            int heldDigits = 0;
            for (int i = 0; i < n; i++)
            {
                int carriedOver = 0;
                int sum = 0;
                for (int j = boxes - 1; j >= 0; j--)
                {
                    reminders[j] *= 10;
                    sum = reminders[j] + carriedOver;
                    int quotient = sum / (j * 2 + 1);
                    reminders[j] = sum % (j * 2 + 1);
                    carriedOver = quotient * j;
                }
                reminders[0] = sum % 10;
                int q = sum / 10;
                if (q == 9)
                {
                    heldDigits++;
                }
                else if (q == 10)
                {
                    q = 0;
                    for (int k = 1; k <= heldDigits; k++)
                    {
                        int replaced = Int32.Parse(pi.ToString(i - k, 1));
                        if (replaced == 9)
                        {
                            replaced = 0;
                        }
                        else
                        {
                            replaced++;
                        }
                        pi.Remove(i - k, 1);
                        pi.Insert(i - k, replaced);
                    }
                    heldDigits = 1;
                }
                else
                {
                    heldDigits = 1;
                }
                pi.Append(q);
            }
            if (pi.Length >= 2)
            {
                pi.Insert(1, '.');
            }
            return pi.ToString();
        }
    }
}
