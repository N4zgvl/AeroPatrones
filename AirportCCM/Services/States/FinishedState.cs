using AirportCCM.Models;

namespace AirportCCM.Services.States
{
    public class FinishedState : IFlightState
    {
        public void Handle(Flight flight)
        {
            Console.WriteLine($"✅ {flight.FlightCode} aterrizó con éxito.");
        }
    }
}
