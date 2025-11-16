namespace AirportCCM.Services.ChainOfResponsibility
{
    public class GroundStaffHandler : BaseHandler
    {
        public override void Handle(string request)
        {
            if (request.Contains("equipaje"))
            {
                Console.WriteLine("🛄 Personal de tierra resolvió solicitud de equipaje.");
            }
            else
            {
                Console.WriteLine("➡️ Escalando solicitud desde personal de tierra…");
                base.Handle(request);
            }
        }
    }
}
