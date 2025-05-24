using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;

namespace dynamically_invoke.utilities
{
    internal class invokes
    {
        public static void dynamicallyInvoke(string code, string args = "")
        {
            var codeProvider = new CSharpCodeProvider();
            var parameters = new CompilerParameters() { GenerateExecutable = false, GenerateInMemory = false };

            BindingFlags flags = BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static;

            #region Referenced Assemblies
            parameters.ReferencedAssemblies.Add("System.Linq.dll");
            #endregion

            var results = codeProvider.CompileAssemblyFromSource(parameters, code);

            if (results.Errors.Count > 0 || results.ToString().Length == 0)
            {
                foreach (CompilerError error in results.Errors) { Console.WriteLine("Error: " + error.ErrorText); }
            }
            else
            {
                if (args != "")
                {
                    Assembly assembly = results.CompiledAssembly;
                    Type program = assembly.GetType("RxrityVPN.Program");
                    MethodInfo main = program.GetMethod("method", flags);

                    object o = results.CompiledAssembly.CreateInstance("RxrityVPN.Program");

                    main.Invoke(o, new object[] { $"{args}" });
                }
                else
                {
                    Assembly assembly = results.CompiledAssembly;
                    Type program = assembly.GetType("RxrityVPN.Program");
                    MethodInfo main = program.GetMethod("method", flags);

                    object o = results.CompiledAssembly.CreateInstance("RxrityVPN.Program");

                    main.Invoke(o, null);
                }
            }
        }
    }
}
