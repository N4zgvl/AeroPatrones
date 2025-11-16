using AirportCCM.Models;

namespace AirportCCM.Services.State
{
    public class FreeState : IRunwayState
    {
        public string Handle(Runway runway)
        {
            return $"🟢 Pista {runway.RunwayCode} libre y lista para aterrizaje.";
        }
    }
}
