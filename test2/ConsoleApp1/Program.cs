
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace ConsoleApp1

{
    class OpenXmlElement
    {
         static void Main(string[] args)
        {
            string wordPathString = @"C:\Users\Administrator.MICROSO-IJAJHM4\Desktop\github\test\test2\OpenXML\科研细则.docx";
            using (WordprocessingDocument wordprocessing = WordprocessingDocument.Open(wordPathString,false))
            {
                Body b = wordprocessing.MainDocumentPart.Document.Body;  //创建一个Body类并存储内容
                foreach (var paragraph in b.Elements<Paragraph>())
                {
                    Console.WriteLine(paragraph.InnerText);  //动态改变网页内容，遍历对象并依次打印
                }
            }
            Console.ReadLine();
        }
    }
}