using AirportCCM.Models;

namespace AirportCCM.Services.State
{
    public interface IRunwayState
    {
        string Handle(Runway runway);
    }
}
