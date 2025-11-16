namespace AirportCCM.Services.Observer
{
    public class TowerControl : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"📡 Torre recibe alerta: {message}");
        }
    }
}
