using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_4
{
    public class Permutations
    {
        private List<string> permutationsList;
        private String str;
        private void AddToList(char[] a, bool repeat = true)
        {
            var bufer = new StringBuilder("");
            for (int i = 0; i < a.Count(); i++)
            {
                bufer.Append(a[i]);
            }
            if (repeat || !permutationsList.Contains(bufer.ToString()))
            {
                permutationsList.Add(bufer.ToString());
            }
        }
        private void RecPermutation(char[] a, int n, bool repeat = true)
        {
            for (var i = 0; i < n; i++)
            {
                var temp = a[n - 1];
                for (var j = n - 1; j > 0; j--)
                {
                    a[j] = a[j - 1];
                }
                a[0] = temp;
                if (i < n - 1) AddToList(a, repeat);
                if (n > 0) RecPermutation(a, n - 1, repeat);
            }
        }
        public Permutations()
        {
            str = "";
        }
        public Permutations(String str)
        {
            this.str = str;
        }
        public String PermutationStr
        {
            get
            {
                return str;
            }
            set
            {
                str = value;
            }
        }
        public List<string> GetPermutationsList(bool repeat = true)
        {
            permutationsList = new List<string> { str };
            RecPermutation(str.ToArray(), str.Length, repeat);
            return permutationsList;
        }
        public List<string> GetPermutationsSortList(bool repeat = true)
        {
            GetPermutationsList(repeat).Sort();
            return permutationsList;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const string str = "ира";
            var per = new Permutations(str);
            var list = per.GetPermutationsList();

            foreach (var l in list)
            {
                Console.WriteLine(l);
            }
        }
    }
}
