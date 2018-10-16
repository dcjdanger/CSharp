实验二

对于OpenXmlElement 类，
我也是第一次接触，并不是特别懂这个类的运用，
之所以去网上了解了一下OpenXmlElement 类处理的都是一些小数据量的XML文件，都是直接用.Net Framework中System.XML命名空间下的基本的XmlDocument、XmlElement、XmlNode等基本类，读取了节点之后，
获取属性及其内部文本内容，但是这种方法在处理小文本量XML数据时，
尚可使用，一旦处理较大数据量的XML数据，就显得那么笨拙，效率也低下。
参考了一下网上的代码，并在项目里的ConsoleApp1命名空间里右键点击管理
NuGet管理包，搜索OpenXml，下载DocumentFormat.OpenXml这个包，上面
会出现
using DocumentFormat.OpenXml.Packaging;     
using DocumentFormat.OpenXml.Wordprocessing;

string wordPathString = @"C:\Users\Administrator.MICROSO-IJAJHM4\Desktop\github\test\test2\OpenXML\科研细则.docx";
将科研细则的路径存储在wordPathString这个字符串空间里，         
  
 using (WordprocessingDocument wordprocessing = WordprocessingDocument.Open(wordPathString,false))
 从WordprocessingDocument类中创建一个新的实例，并将科研细则的地址
 存放在这个wordprocessing变量中。
 
  Body b = wordprocessing.MainDocumentPart.Document.Body;  
                 foreach (var paragraph in b.Elements<Paragraph>())
                 {
                     Console.WriteLine(paragraph.InnerText);  
                 }
   创建一个Body类并存储内容，动态改变网页内容，遍历对象并依次打印文档中
   的段落和文字。
   
   以上就是我的个人理解，对于初学并不能很好地理解，希望老师指出错误。


