namespace AirportCCM.Services.ChainOfResponsibility
{
    public class SupervisorHandler : BaseHandler
    {
        public override void Handle(string request)
        {
            if (request.Contains("autorización"))
            {
                Console.WriteLine("🛂 Supervisor aprobó la autorización especial.");
            }
            else
            {
                Console.WriteLine("➡️ Escalando solicitud desde supervisor…");
                base.Handle(request);
            }
        }
    }
}
