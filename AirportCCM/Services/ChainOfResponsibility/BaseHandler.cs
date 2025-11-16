namespace AirportCCM.Services.ChainOfResponsibility
{
    public abstract class BaseHandler : IRequestHandler
    {
        private IRequestHandler _next;

        public IRequestHandler SetNext(IRequestHandler next)
        {
            _next = next;
            return next;
        }

        public virtual void Handle(string request)
        {
            if (_next != null)
                _next.Handle(request);
            else
                Console.WriteLine("❌ Ningún handler pudo manejar la solicitud.");
        }
    }
}
