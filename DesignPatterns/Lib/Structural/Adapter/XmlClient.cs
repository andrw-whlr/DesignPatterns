using System.Xml;

namespace Lib.Structural.Adapter
{
    public class XmlClient : IXmlClient
    {
        public XmlDocument GetData()
        {
            var xmlString = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><message><warning>Hello World</warning></message>";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlString);
            return doc;
        }
    }
}