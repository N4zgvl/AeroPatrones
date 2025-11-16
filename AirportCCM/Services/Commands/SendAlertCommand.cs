namespace AirportCCM.Services.Commands
{
    public class SendAlertCommand : ICommand
    {
        private readonly string _message;

        public SendAlertCommand(string message)
        {
            _message = message;
        }

        public void Execute()
        {
            Console.WriteLine($"🚨 ALERTA DEL AEROPUERTO: {_message}");
        }
    }
}
