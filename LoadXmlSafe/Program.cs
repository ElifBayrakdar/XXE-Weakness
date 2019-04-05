using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LoadXmlSafe
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDocument = new XmlDocument();
            string xml = @"<xml>
                      <node> test </node>
                       </xml> ";
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.XmlResolver = null;
            settings.DtdProcessing = DtdProcessing.Prohibit;
            using (StringReader sr = new StringReader(xml))
            using (XmlReader reader = XmlReader.Create(sr, settings))
            {
                xmlDocument.Load(reader);
            }
            Console.ReadKey();
        }
    }
}
