namespace AirportCCM.Services.TemplateMethod
{
    public class CommercialLanding : LandingProcess
    {
        protected override void RequestRunway()
        {
            Console.WriteLine("🛩 Solicitando pista larga (pista 1).");
        }

        protected override void LandAircraft()
        {
            Console.WriteLine("✈️ Aterrizaje estándar para avión comercial.");
        }
    }
}
