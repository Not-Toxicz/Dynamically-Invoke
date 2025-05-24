using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamically_invoke
{
    internal class Program
    {
        static string codetext =
            @"
                using System;
                using System.Collections.Generic;
                using System.Linq;
                using System.Runtime.CompilerServices;
                using System.Text;
                using System.Threading.Tasks;

                namespace RxrityVPN
                {
                    internal class Program
                    {
                        private static string info = ""I might kiss you"";
                        public static string method()
                        {
                            return info;
                        }

                        static void Main(string[] args)
                        {
                            method();
                        }
                    }
                }
            ";

        static void Main(string[] args)
        {
            dynamically_invoke.utilities.invokes.dynamicallyInvoke(codetext);
        }
    }
}
