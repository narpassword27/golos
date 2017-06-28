using System.Collections.Generic;
using System.Linq;
using System;

namespace Core
{
    static class CoreMain
    {
        public static List<IFunction> Modules = GetModules();
        public static Dictionary<IFunction, List<IApp>> Apps =
            Modules
                .ToDictionary(f => f, f => f.Apps);



        public static List<IFunction> GetModules()
        {





            return null;
        }
    }
}