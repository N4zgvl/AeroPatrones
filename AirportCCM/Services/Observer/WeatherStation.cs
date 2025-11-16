namespace AirportCCM.Services.Observer
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> _observers = new();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var obs in _observers)
                obs.Update(message);
        }

        public void ChangeWeather(string condition)
        {
            Notify($"🌦️ Cambio de clima detectado: {condition}");
        }
    }
}
