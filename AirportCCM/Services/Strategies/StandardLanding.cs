using AirportCCM.Models;

namespace AirportCCM.Services.Strategies
{
    public class StandardLanding : ILandingStrategy
    {
        public void ExecuteLanding(Flight flight)
        {
            Console.WriteLine($"Aterrizaje estándar para vuelo {flight.FlightCode}");
        }
    }
}
