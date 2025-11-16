using AirportCCM.Models;

namespace AirportCCM.Services
{
    public static class FlightFactory
    {
        public static Flight CreateFlight(string type)
        {
            return type.ToLower() switch
            {
                "comercial" => new CommercialFlight(),
                "carga" => new CargoFlight(),
                "emergencia" => new EmergencyFlight(),
                _ => throw new ArgumentException("Tipo de vuelo no válido")
            };
        }
    }
}
