
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ReadWord
    {
        //原篇
        public string[] ReadList()
        {
            string fileName = @"C:\Users\Administrator.MICROSO-IJAJHM4\Desktop\github\C#_work\CSharp\test3\国考_原题.docx";
            //string fileName = @"D:\Program Files\VS2017_workplace\test3\11.docx";
            using (WordprocessingDocument wordprocessingDocument =WordprocessingDocument.Open(fileName, false))
            {
                // Create a Body object.
                DocumentFormat.OpenXml.Wordprocessing.Body body =wordprocessingDocument.MainDocumentPart.Document.Body;

                List<string> list = new List<string>();
                foreach (var g in body.Elements())
                {
                    list.Add(g.InnerText);
                }

               /* foreach(var s in list)
                {
                    Console.WriteLine(s);
                }*/
                
                //初始化一个字符数组
                char[] ch = new char[list.Count];
                //将list转化为字符串数组
                string[] str = list.ToArray();
                //调用函数转化为字符数组
                Operation CH = new Operation();
                ch = CH.OperationCh(str, list.Count);
                //再转换为string[]
                string[] s = new string[ch.Length];
                //调用函数
                s = CH.changeStr(ch);
                return s;

            }
        }
        //第一篇
        public string[] ReadList1()
        {
            string fileName = @"C:\Users\Administrator.MICROSO-IJAJHM4\Desktop\github\C#_work\CSharp\test3\国考_标准答案1.docx";

            using (WordprocessingDocument wordprocessingDocument =WordprocessingDocument.Open(fileName, false))
            {
                // Create a Body object.
                DocumentFormat.OpenXml.Wordprocessing.Body body =wordprocessingDocument.MainDocumentPart.Document.Body;

                List<string> list1 = new List<string>();
                foreach (var g in body.Elements())
                {
                    list1.Add(g.InnerText);
                }
                //初始化一个字符数组
                char[] ch = new char[list1.Count];
                //将list转化为字符串数组
                string[] str = list1.ToArray();
                //调用函数转化为字符数组
                Operation CH = new Operation();
                ch = CH.OperationCh(str, list1.Count);
                //再转换为string[]
                string[] s = new string[ch.Length];
                //调用函数
                s = CH.changeStr(ch);
                return s;
            }
        }
        //第二篇
        public string[] ReadList2()
        {
            string fileName = @"C:\Users\Administrator.MICROSO-IJAJHM4\Desktop\github\C#_work\CSharp\test3\国考_标准答案2.docx";
            using (WordprocessingDocument wordprocessingDocument = WordprocessingDocument.Open(fileName, false))
            {
                // Create a Body object.
                DocumentFormat.OpenXml.Wordprocessing.Body body = wordprocessingDocument.MainDocumentPart.Document.Body;

                List<string> list2 = new List<string>();
                foreach (var g in body.Elements())
                {
                    list2.Add(g.InnerText);
                }
                //初始化一个字符数组
                char[] ch = new char[list2.Count];
                //将list转化为字符串数组
                string[] str = list2.ToArray();
                //调用函数转化为字符数组
                Operation CH = new Operation();
                ch = CH.OperationCh(str, list2.Count);
                //再转换为string[]
                string[] s = new string[ch.Length];
                //调用函数
                s = CH.changeStr(ch);
                return s;
            }
        }
        //第三篇
        public string[] ReadList3()
        {
            string fileName = @"C:\Users\Administrator.MICROSO-IJAJHM4\Desktop\github\C#_work\CSharp\test3\国考_标准答案3.docx";
            using (WordprocessingDocument wordprocessingDocument =WordprocessingDocument.Open(fileName, false))
            {
                // Create a Body object.
                DocumentFormat.OpenXml.Wordprocessing.Body body =wordprocessingDocument.MainDocumentPart.Document.Body;

                List<string> list3 = new List<string>();
                foreach (var g in body.Elements())
                {
                    list3.Add(g.InnerText);
                }
                //初始化一个字符数组
                char[] ch = new char[list3.Count];
                //将list转化为字符串数组
                string[] str = list3.ToArray();
                //调用函数转化为字符数组
                Operation CH = new Operation();
                ch = CH.OperationCh(str, list3.Count);
                //再转换为string[]
                string[] s = new string[ch.Length];
                //调用函数
                s = CH.changeStr(ch);
                return s;
            }
        }
        //第四篇
        public string[] ReadList4()
        {
            string fileName = @"C:\Users\Administrator.MICROSO-IJAJHM4\Desktop\github\C#_work\CSharp\test3\国考_原题.docx";
            using (WordprocessingDocument wordprocessingDocument =WordprocessingDocument.Open(fileName, false))
            {
                // Create a Body object.
                DocumentFormat.OpenXml.Wordprocessing.Body body =wordprocessingDocument.MainDocumentPart.Document.Body;

                List<string> list4 = new List<string>();
                foreach (var g in body.Elements())
                {
                    list4.Add(g.InnerText);
                }
                //初始化一个字符数组
                char[] ch = new char[list4.Count];
                //将list转化为字符串数组
                string[] str = list4.ToArray();
                //调用函数转化为字符数组
                Operation CH = new Operation();
                ch = CH.OperationCh(str, list4.Count);
                //再转换为string[]
                string[] s = new string[ch.Length];
                //调用函数
                s = CH.changeStr(ch);
                return s;

            }
        }
    }
}
    
