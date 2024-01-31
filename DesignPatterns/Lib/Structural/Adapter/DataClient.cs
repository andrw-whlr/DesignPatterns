using System.Xml;

namespace Lib.Structural.Adapter
{
    public class DataClient
    {
        private readonly IDataEndPoint _dataEndPoint;
        public DataClient(IDataEndPoint dataEndPoint)
        {
            _dataEndPoint = dataEndPoint;
        }
        public void SendData(XmlDocument data)
        {
            _dataEndPoint.SendData(data);
        }
    }
}