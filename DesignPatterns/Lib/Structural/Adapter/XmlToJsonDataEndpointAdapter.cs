using System.Xml;

namespace Lib.Structural.Adapter
{
    public class XmlToJsonDataEndpointAdapter : IDataEndPoint
    {
        public XmlToJsonDataEndpointAdapter()
        {
            _jsonDataEndpoint = new JsonDataEndpoint();
        }

        private readonly JsonDataEndpoint _jsonDataEndpoint;

        public bool SendData(XmlDocument data)
        {
            var json = ConvertXmlToJson(data);
            return _jsonDataEndpoint.SendData(json);
        }

        private string ConvertXmlToJson(XmlDocument data)
        {
            //convert xml to json
            return "{  }";
        }
    }
}