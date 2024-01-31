using System.Data;
using System.Xml;

namespace Lib.Structural.Adapter
{
    public class XmlDataEndpoint : IDataEndPoint
    {
        public bool SendData(XmlDocument data)
        {
            if (data.ChildNodes.Count < 1) return false;
            return true;
        }
    }
}