namespace Lib.Structural.Adapter
{
    public class JsonDataEndpoint
    {
        public bool SendData(string data)
        {
            //check if string is json 
            //trivial but it's just an example
            if (data.StartsWith("{") && data.EndsWith("}"))
            {
                return true;
            }
            else
            {
                throw new System.ArgumentException("Data is not in JSON format");
            }
            
        }
    }
}