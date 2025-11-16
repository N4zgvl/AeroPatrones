using AirportCCM.Models;

namespace AirportCCM.Services.States
{
    public class InFlightState : IFlightState
    {
        public void Handle(Flight flight)
        {
            Console.WriteLine($"🛫 {flight.FlightCode} está en vuelo.");
            flight.ChangeState(new LandingState());
        }
    }
}
