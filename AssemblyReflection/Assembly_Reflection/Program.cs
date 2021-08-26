using System;
using System.Reflection;

namespace Assembly_Reflection
{

    class Program
    {
        // UPDATE PATH TO MATCH YOUR FILE LOCATION
        static string path = "C:\\Users\\OJ\\source\\VC\\PROG Y2\\AssemblyReflection\\AssemblyReflection\\bin\\Debug\\net5.0\\AssemblyReflection.dll";

        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFile(path);

            Type[] type = assembly.GetTypes();

            foreach (var types in type)
            {
                Console.WriteLine($"Types: {types}");

                PropertyInfo[] properties = types.GetProperties();
                foreach (var property in properties)
                {
                    Console.WriteLine($"Properties: {property.Name}");
                }

                MethodInfo[] method = types.GetMethods();
                foreach (var methods in method)
                {
                    Console.WriteLine("============================================");
                    Console.WriteLine($"Methods: {methods.Name}");

                    ParameterInfo[] parameters = methods.GetParameters();
                    foreach (var parameter in parameters)
                    {
                        Console.WriteLine("============================================");
                        Console.WriteLine($"Parameter name: {parameter.Name}");
                    }
                }

                // ICE TASK
                // print out the constructors 
                // print out the references
            }
        }
    }
}
