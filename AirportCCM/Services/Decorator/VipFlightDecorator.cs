namespace AirportCCM.Services.Decorator
{
    public class VipFlightDecorator : FlightDecorator
    {
        public VipFlightDecorator(IFlightProcess flight) : base(flight) { }

        public override void Process()
        {
            base.Process();
            Console.WriteLine("💼 Acceso VIP prioritario");
        }
    }
}
