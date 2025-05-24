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
                ﻿using System;
                using System.Collections.Generic;
                using System.Linq;
                using System.Text;
                using System.Threading.Tasks;
                
                namespace RxrityVPN
                {
                    internal class Program
                    {
                        public static void method()
                        {
                            Console.WriteLine(""Hello World! <3"");
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
