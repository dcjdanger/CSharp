using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ 
    class Operation
    {
        public char[] OperationCh(string[] str, int length)
        {
            char[] ch = new char[length];
            for (int i = 0; i < str.Length; i++)
            {
                char[] ch1 = str[i].ToCharArray();
                ch = ch.Concat(ch1).ToArray();
            }
            return ch;
        }
        public string[] changeStr(char[] ch)
        {
            string[] str = new string[ch.Length];
            for (int i = 0; i < ch.Length; i++)
            {
                str[i] = ch[i].ToString();
            }
            return str;
        }
    }
}
