namespace Core
{
    public class Request
    {
        public IApp App { get; }
        public string[] Argument { get; }

        public Request (IApp _app, string[] _argument)
        {
            this.App = _app;
            this.Argument = _argument;
        }

        public void Respond()
        {
            this.App.Respond();
            this.App.Do();
        }
    }
}