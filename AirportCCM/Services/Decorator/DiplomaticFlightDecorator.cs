namespace AirportCCM.Services.Decorator
{
    public class DiplomaticFlightDecorator : FlightDecorator
    {
        public DiplomaticFlightDecorator(IFlightProcess flight) : base(flight) { }

        public override void Process()
        {
            base.Process();
            Console.WriteLine("🎖️ Vuelo diplomático — se otorga protocolo especial");
        }
    }
}
