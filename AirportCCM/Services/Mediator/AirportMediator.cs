using AirportCCM.Models;
using AirportCCM.Services.Observer;
using AirportCCM.Services.State;

namespace AirportCCM.Services.Mediator
{
    public class AirportMediator
    {
        private readonly WeatherStation _weatherStation;
        private readonly TowerControl _tower;

        public AirportMediator()
        {
            _weatherStation = new WeatherStation();
            _tower = new TowerControl();

            _weatherStation.Attach(_tower);
        }

        public void ChangeWeather(string condition)
        {
            _weatherStation.ChangeWeather(condition);
        }

        public string AssignRunway(Runway runway, string action)
        {
            switch (action.ToLower())
            {
                case "usar":
                    runway.SetState(new OccupiedState());
                    break;
                case "mantenimiento":
                    runway.SetState(new MaintenanceState());
                    break;
                default:
                    runway.SetState(new FreeState());
                    break;
            }

            string msg = runway.Operate();
            Console.WriteLine($"🛫 Torre informa: {msg}");
            return msg;
        }
    }
}
