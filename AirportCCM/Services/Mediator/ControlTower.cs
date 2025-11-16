using AirportCCM.Models;
using AirportCCM.Services.Observer;

namespace AirportCCM.Services.Mediator
{
    // Interfaz del Mediador
    public interface IControlTower
    {
        void RegisterFlight(Flight flight);
        void Notify(Flight flight, string message);
    }

    // Implementación del Mediador concreto
    public class ControlTower : IControlTower, IObserver
    {
        private readonly List<Flight> _flights = new();

        public void RegisterFlight(Flight flight)
        {
            if (!_flights.Contains(flight))
            {
                _flights.Add(flight);
                flight.SetTower(this);
            }
        }

        public void Notify(Flight flight, string message)
        {
            Console.WriteLine($"📡 Torre: mensaje de {flight.FlightCode} → {message}");
        }

        public void Update(string message)
        {
            Console.WriteLine($"📡 Torre recibe actualización → {message}");
        }
    }

}
