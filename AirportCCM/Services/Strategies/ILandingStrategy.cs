using AirportCCM.Models;

namespace AirportCCM.Services.Strategies
{
    public interface ILandingStrategy
    {
        void ExecuteLanding(Flight flight);
    }
}
