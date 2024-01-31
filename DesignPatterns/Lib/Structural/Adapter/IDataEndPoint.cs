using System.Xml;

namespace Lib.Structural.Adapter
{
    public interface IDataEndPoint
    {
        bool SendData(XmlDocument data);
    }
}