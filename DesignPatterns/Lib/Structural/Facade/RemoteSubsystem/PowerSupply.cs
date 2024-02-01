namespace Lib.Structural.Facade.TelevisionRemoteSubsystem
{
    public class PowerSupply
    {
        public bool IsOn { get; private set; }
        public void TurnOn()
        {
            IsOn = true;
        }

        public void TurnOff()
        {
            IsOn = false;
        }
    }
}