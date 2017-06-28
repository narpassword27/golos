using System;
using System.Collections.Generic;

namespace Core
{
    public class Command : IFunction
    {
        public List<IApp> Apps => throw new NotImplementedException();

        public void Do(IApp App, string[] Argument) => App.Do();
    }
}
