using AirportCCM.Models;

namespace AirportCCM.Services.State
{
    public class OccupiedState : IRunwayState
    {
        public string Handle(Runway runway)
        {
            return $"🔴 Pista {runway.RunwayCode} ocupada — vuelo aterrizando.";
        }
    }
}
