using AirportCCM.Models;

namespace AirportCCM.Services.State
{
    public class MaintenanceState : IRunwayState
    {
        public string Handle(Runway runway)
        {
            return $"🟡 Pista {runway.RunwayCode} en mantenimiento.";
        }
    }
}
