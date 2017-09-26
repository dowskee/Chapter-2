using System;
using System.Reflection;

namespace Ch02_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Xml.XmlReader reader;
            System.Xml.Linq.XElement element;
            System.Net.Http.HttpClient client;
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies);

            {
                var a = Assembly.Load(new AssemblyName(r.FullName));
                int methodCount = 0;
                foreach (var t in a.DefinedTypes)
                {
                    methodCount += t.GetMethods().Count();
                }
                Console.WriteLine($"{a.DefinedTypes.Count():N0} types") + $"with {methodCount:N0} methods in {r.Name} assembly");
            }
        }
    }
}
