using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System;

namespace codealong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new user("Didrik");
            user.Menu();
        }
    }
}
