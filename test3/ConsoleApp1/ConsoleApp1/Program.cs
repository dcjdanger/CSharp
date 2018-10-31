using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWord rwnb = new ReadWord();
            Console.WriteLine("****************************文档题目试题库比对系统******************************");
            Console.WriteLine("请选择标号1、2、3、4");
            // int c = 0;
            string s1 = Console.ReadLine();
            // c = int.Parse(s1);

            if (s1.Equals("1"))
            {
                LCS<string> strLCS1 = new LCS<string>(rwnb.ReadList(), rwnb.ReadList1());
                strLCS1.Demo();
            }
            else if (s1.Equals("2"))
            {
                LCS<string> strLCS2 = new LCS<string>(rwnb.ReadList(), rwnb.ReadList2());
                strLCS2.Demo();
            }
            else if (s1.Equals("3"))
            {
                LCS<string> strLCS3 = new LCS<string>(rwnb.ReadList(), rwnb.ReadList3());
                strLCS3.Demo();
            }
            else if ((s1.Equals("4")))
            {
                LCS<string> strLCS4 = new LCS<string>(rwnb.ReadList(), rwnb.ReadList4());
                strLCS4.Demo();
            }
            else
            {
                Console.WriteLine("error!{0}", s1);
                Console.WriteLine("Please input Any Key Out and go operating！");
            }

            Console.ReadKey();


        }

        /*
        internal class LCS<T>
        {
            private object p1;
            private object p2;

            public LCS(object p1, object p2)
            {
                this.p1 = p1;
                this.p2 = p2;
            }

            internal void Demo()
            {
                throw new NotImplementedException();
            }
        }

        internal class ReadWord
        {
            public ReadWord()
            {
            }

            internal object ReadList()
            {
                throw new NotImplementedException();
            }

            internal object ReadList1()
            {
                throw new NotImplementedException();
            }

            internal object ReadList2()
            {
                throw new NotImplementedException();
            }

            internal object ReadList3()
            {
                throw new NotImplementedException();
            }

            internal object ReadList4()
            {
                throw new NotImplementedException();
            }

        }*/
    }
}
   
 




