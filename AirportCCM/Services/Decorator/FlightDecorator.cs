namespace AirportCCM.Services.Decorator
{
    public abstract class FlightDecorator : IFlightProcess
    {
        protected IFlightProcess _flight;

        protected FlightDecorator(IFlightProcess flight)
        {
            _flight = flight;
        }

        public virtual void Process()
        {
            _flight.Process();
        }
    }
}
