using AirportCCM.Services.Decorator;
using AirportCCM.Services.Mediator;
using AirportCCM.Services.Observer;
using AirportCCM.Services.States;
using AirportCCM.Services.Strategies;

namespace AirportCCM.Models
{
    public  class Flight : ISubject, IFlightProcess
    {
        public string FlightCode { get; set; }
        public string Airline { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }

        // Strategy → comportamiento de aterrizaje
        public ILandingStrategy LandingStrategy { get; set; }

        public void Land()
        {
            LandingStrategy.ExecuteLanding(this);
        }

        private IControlTower? _tower;
        public IFlightState State { get; set; } = new ScheduledState(); // Patrón State

        public void SetTower(IControlTower tower)
        {
            _tower = tower;
        }

        //public void ChangeState(IFlightState newState)
        //{
        //    State = newState;
        //    _tower?.Notify(this, $"Cambio de estado → {State.GetType().Name}");
        //}

        public void Proceed()
        {
            State.Handle(this);
        }

        private readonly List<IObserver> _observers = new();

        // --- Métodos del patrón Observer ---
        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Detach(IObserver observer) => _observers.Remove(observer);

        public void Notify(string message)
        {
            foreach (var obs in _observers)
            {
                obs.Update(message);
            }
        }

        // --- Método para cambiar estado (ya existente, ahora con Notify) ---
        public void ChangeState(IFlightState newState)
        {
            State = newState;
            Notify($"✈️ Vuelo {FlightCode} cambió al estado {newState.GetType().Name}");
        }


        public virtual void Process()
        {
            Console.WriteLine($"✈️ Procesando vuelo {FlightCode}");
        }

    }
}
