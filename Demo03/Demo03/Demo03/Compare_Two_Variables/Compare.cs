using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Compare_Two_Variables
{
    internal static class Compare
    {
        public static bool CompareGreater(int a, int b) { return a > b; }
        public static bool CompareLess(int a, int b) { return a < b; }

        public static bool CompareGreater(string a, string b) { return a.Length > b.Length; }
        public static bool CompareLess(string a, string b) { return a.Length < b.Length; }


    }
}
