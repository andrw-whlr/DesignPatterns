namespace Lib.Structural.Facade
{
    public class RemoteFacade
    {
        public void GimmeNetflix()
        {
            var powerSupply = new TelevisionRemoteSubsystem.PowerSupply();
            powerSupply.TurnOn();
            var physicalInput = new TelevisionRemoteSubsystem.PhysicalInput(powerSupply);
            physicalInput.SetInput("NETFLIX");
            var infaredSignal = new TelevisionRemoteSubsystem.InfaredSignal(powerSupply, physicalInput);
            infaredSignal.Transmit(physicalInput.Input);
        }
    }
}