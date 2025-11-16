using AirportCCM.Models;

namespace AirportCCM.Services.States
{
    public class ScheduledState : IFlightState
    {
        public void Handle(Flight flight)
        {
            Console.WriteLine($"✈️ {flight.FlightCode} programado para despegar.");
            flight.ChangeState(new InFlightState());
        }
    }
}
