namespace AirportCCM.Services.Decorator
{
    public class CriticalEmergencyDecorator : FlightDecorator
    {
        public CriticalEmergencyDecorator(IFlightProcess flight) : base(flight) { }

        public override void Process()
        {
            base.Process();
            Console.WriteLine("🚨 Emergencia crítica — prioridad absoluta en pista!");
        }
    }
}
