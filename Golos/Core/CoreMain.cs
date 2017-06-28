using System.Collections.Generic;
using System.Linq;
using System;

namespace Core
{
    static class CoreMain
    {
        public static List<IFunction> Modules = GetModules();
        public static Dictionary<Type, Type> Apps =
                .SelectMany(f => f.Apps)
                .ToDictionary(f, )



        public static List<IFunction> GetModules()
        {





            return null;
        }
    }
}