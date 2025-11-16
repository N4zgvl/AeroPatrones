namespace AirportCCM.Services.Commands
{
    public class CommandInvoker
    {
        private readonly Queue<ICommand> _queue = new();

        public void AddCommand(ICommand command)
        {
            _queue.Enqueue(command);
        }

        public void ExecuteAll()
        {
            while (_queue.Count > 0)
            {
                var cmd = _queue.Dequeue();
                cmd.Execute();
            }
        }
    }
}
