namespace AirportCCM.Services.TemplateMethod
{
    public abstract class LandingProcess
    {
        // Template Method
        public void ExecuteLanding(string flight)
        {
            Console.WriteLine($"\n🔽 Iniciando proceso de aterrizaje para {flight}");

            ContactTower();
            RequestRunway();
            LandAircraft();
            GoToGate();
            ShutdownEngines();

            Console.WriteLine($"✔️ Aterrizaje completado para {flight}\n");
        }

        protected void ContactTower()
            => Console.WriteLine("📡 Contactando torre de control...");

        protected abstract void RequestRunway();
        protected abstract void LandAircraft();

        protected virtual void GoToGate()
            => Console.WriteLine("🛬 Rodando hacia la puerta asignada...");

        protected virtual void ShutdownEngines()
            => Console.WriteLine("⛽ Motores apagados.");
    }
}
