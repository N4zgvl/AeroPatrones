namespace AirportCCM.Services.ChainOfResponsibility
{
    public class ManagerHandler : BaseHandler
    {
        public override void Handle(string request)
        {
            Console.WriteLine($"🧑‍✈️ Gerente del aeropuerto manejó la solicitud final: {request}");
        }
    }
}
