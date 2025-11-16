using AirportCCM.Services.State;

namespace AirportCCM.Models
{
    public class Runway
    {
        public string RunwayCode { get; set; }
        public IRunwayState State { get; set; }

        public Runway(string code)
        {
            RunwayCode = code;
            State = new FreeState(); // inicial
        }

        public void SetState(IRunwayState newState)
        {
            State = newState;
        }

        public string Operate()
        {
            return State.Handle(this);
        }
    }
}
