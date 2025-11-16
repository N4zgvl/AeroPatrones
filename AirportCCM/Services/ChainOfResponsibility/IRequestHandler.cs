namespace AirportCCM.Services.ChainOfResponsibility
{
    public interface IRequestHandler
    {
        IRequestHandler SetNext(IRequestHandler next);
        void Handle(string request);
    }
}
