using Lib.Structural.Adapter;
using System.Xml;

namespace Tests.Structural
{
    public class AdapterPatternTests
    {

        [Test]
        public void Adapter_XmlDataEndpoint_SendData_ReturnsTrue()
        {
            var xmlData = new XmlDocument();
            xmlData.LoadXml("<?xml version=\"1.0\" ?><node1><node2></node2></node1>");
            var xmlDataEndpoint = new XmlDataEndpoint();
            var dataClient = new DataClient(xmlDataEndpoint);
            dataClient.SendData(xmlData);
        }

        [Test]
        public void Adapter_JsonDataEndpoint_SendData_ReturnsTrue()
        {
            var xmlData = new XmlDocument();
            xmlData.LoadXml("<?xml version=\"1.0\" ?><node1><node2></node2></node1>");
            var jsonDataEndpoint = new XmlToJsonDataEndpointAdapter();
            var dataClient = new DataClient(jsonDataEndpoint);
            dataClient.SendData(xmlData);
        }
    }
}