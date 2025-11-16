namespace AirportCCM.Services.Decorator
{
    public class HazardousCargoDecorator : FlightDecorator
    {
        public HazardousCargoDecorator(IFlightProcess flight) : base(flight) { }

        public override void Process()
        {
            base.Process();
            Console.WriteLine("☢️ Advertencia: carga peligrosa a bordo");
        }
    }
}
