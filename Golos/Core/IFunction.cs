using System.Collections.Generic;

namespace Core
{
    public interface IFunction
    {
        List<IApp> Apps { get; }
        void Do(IApp App, string[] Argument);
    }
}