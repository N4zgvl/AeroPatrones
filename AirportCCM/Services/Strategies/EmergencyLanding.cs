using AirportCCM.Models;

namespace AirportCCM.Services.Strategies
{
    public class EmergencyLanding :ILandingStrategy
    {
        public void ExecuteLanding(Flight flight)
        {
            Console.WriteLine($"⚠️ ATENCIÓN: Aterrizaje de emergencia para vuelo {flight.FlightCode}");
        }
    }
}
