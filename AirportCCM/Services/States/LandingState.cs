using AirportCCM.Models;

namespace AirportCCM.Services.States
{
    public class LandingState : IFlightState
    {
        public void Handle(Flight flight)
        {
            Console.WriteLine($"🛬 {flight.FlightCode} iniciando aterrizaje.");
            flight.ChangeState(new FinishedState());
        }
    }
}
