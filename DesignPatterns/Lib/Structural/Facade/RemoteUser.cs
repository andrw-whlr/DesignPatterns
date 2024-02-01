namespace Lib.Structural.Facade
{
    public class RemoteUser
    {
        public bool IsBingeWatching { get; private set; }
        public void ClickNetflix()
        {
            var remote = new RemoteFacade();
            remote.GimmeNetflix();
            IsBingeWatching = true;
        }
    }
}