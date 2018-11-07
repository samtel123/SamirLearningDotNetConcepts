using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StudyExamples
{
    class StudyXML
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(Resource.hardware);
            XmlNode rootNode = xmlDocument.DocumentElement;
            foreach (XmlNode nodeLevel1 in rootNode.ChildNodes)
            {
               // Console.WriteLine("\n" + nodeLevel1.InnerText.ToString());
                //Console.WriteLine("\n" + nodeLevel1.InnerXml.ToString());

                foreach (XmlNode nodeLevel2 in nodeLevel1.ChildNodes)
                {
                  //  Console.WriteLine("\n" + nodeLevel2.InnerText.ToString());

                    if (nodeLevel2.Attributes.Count > 0)
                    {
                        Console.WriteLine(nodeLevel2.Attributes[0].Name + ":" + nodeLevel2.Attributes[0].Value);
                    }
                    if (nodeLevel2.ChildNodes.Count > 0)
                    {
                        foreach (XmlNode item in nodeLevel2)
                        {
                            Console.WriteLine("\t" + item.Name + "\t" + item.InnerText);
                        }
                    }
                   // Console.WriteLine("\n" + nodeLevel2.Value);
                }
            }          
            Console.Read();
        }

    }
}
