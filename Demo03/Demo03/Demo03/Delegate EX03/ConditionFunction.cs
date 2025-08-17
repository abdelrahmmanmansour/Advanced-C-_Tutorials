using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Delegate_EX03
{
    internal static class ConditionFunction
    {
        public static bool EvenList(int num) { return num % 2 == 0; }
        public static bool OddList(int num) { return num % 2 != 0; }
        public static bool LengthGreater4(string name) { return name.Length > 4; }
        public static bool LengthLess4(string name) { return name.Length < 4; }
    }
}
