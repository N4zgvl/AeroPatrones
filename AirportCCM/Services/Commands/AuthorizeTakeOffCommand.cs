using AirportCCM.Models;
using AirportCCM.Services.States;

namespace AirportCCM.Services.Commands
{
    public class AuthorizeTakeOffCommand : ICommand
    {
        private readonly Flight _flight;

        public AuthorizeTakeOffCommand(Flight flight)
        {
            _flight = flight;
        }

        public void Execute()
        {
            Console.WriteLine($"🛫 Autorizando despegue del vuelo {_flight.FlightCode}");
            _flight.ChangeState(new InFlightState());
        }
    }
}
