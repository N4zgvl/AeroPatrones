using AirportCCM.Models;

namespace AirportCCM.Services.States
{
    public interface IFlightState
    {
        void Handle(Flight flight);
    }
}
