using System;

namespace Core
{
    public class Request
    {
        public IFunction Function { get; }
        public IApp App { get; }
        public string[] RawArgument { get; }

        public Request (IFunction _function, IApp _app, string[] _rawArgument)
        {
            this.Function = _function;
            this.App = _app;
            this.RawArgument = _rawArgument;
        }

        public void Respond()
        {

        }
    }
}