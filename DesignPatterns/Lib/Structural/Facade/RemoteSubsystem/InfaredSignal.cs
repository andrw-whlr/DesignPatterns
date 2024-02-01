namespace Lib.Structural.Facade.TelevisionRemoteSubsystem
{
    public class InfaredSignal
    {
        private PowerSupply _powerSupply;
        private PhysicalInput _physicalInput;

        public InfaredSignal(PowerSupply powerSupply, PhysicalInput physicalInput)
        {
            _powerSupply = powerSupply;
            _physicalInput = physicalInput;
        }

        public void Transmit(string signal)
        {
            if (!_powerSupply.IsOn) throw new Exception("No Signal can be sent when the power is off");
            if (!string.IsNullOrWhiteSpace(_physicalInput.Input))
            {
                Console.WriteLine($"Transmitting {signal} signal...");
            }
            
        }
    }
}