namespace AirportCCM.Services.TemplateMethod
{
    public class MilitaryLanding : LandingProcess
    {
        protected override void RequestRunway()
        {
            Console.WriteLine("🚨 Solicitando pista prioritaria y permisos militares.");
        }

        protected override void LandAircraft()
        {
            Console.WriteLine("🛬 Maniobra táctica de aterrizaje militar.");
        }

        protected override void ShutdownEngines()
        {
            Console.WriteLine("🔐 Motores apagados bajo protocolo militar.");
        }
    }
}
