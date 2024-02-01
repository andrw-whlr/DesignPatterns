namespace Lib.Structural.Facade.TelevisionRemoteSubsystem
{
    public class PhysicalInput
    {
        private PowerSupply _powerSupply;

        public PhysicalInput(PowerSupply powerSupply)
        {
            _powerSupply = powerSupply;
        }

        public string? Input { get; private set; }
        public bool InputSent { get; private set; }

        public void SetInput(string input)
        {
            if (!_powerSupply.IsOn) throw new Exception("No Signal can be sent when the power is off");
            Input = input;
            Console.WriteLine($"Setting input to {input}...");
        }

        public void ClearInput()
        {
            Input = string.Empty;
            InputSent = false;
            Console.WriteLine("Clearing input...");
        }
    }
}