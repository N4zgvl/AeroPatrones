namespace AirportCCM.Services.TemplateMethod
{
    public class PrivateLanding : LandingProcess
    {
        protected override void RequestRunway()
        {
            Console.WriteLine("🛩 Solicitando pista corta (pista 3).");
        }

        protected override void LandAircraft()
        {
            Console.WriteLine("🛬 Aterrizaje suave para avión privado.");
        }
    }
}
