using System;
using System.Collections.Generic;

namespace TypeConversions
{
    class Program
    {
        static List<String> _dataTypes = new List<String> () {
           "sbyte", "byte", "short",  "ushort",  "int",  "uint", "long", "ulong", "nint", "nuint", "float", "double", "decimal"
        };
        static void Main(string[] args)
        {
            Window myWindow = new Window();
            CheckImplicity myCheckImplicty = new CheckImplicity();
            for (var i=0; i < _dataTypes.Count; i++) myCheckImplicty.check(_dataTypes[i], i, _dataTypes.Count); 
        }
    }
}
