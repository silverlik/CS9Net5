using System;
using System.Linq;
using System.Reflection;
Console.WriteLine("Hello World!");
foreach(var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
{
    var a = Assembly.Load(new AssemblyName(r.FullName));
    int m = 0;
    foreach(var t in a.DefinedTypes)
        m+=t.GetMethods().Count();
    Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", a.DefinedTypes().Count(), m, r.Name);
}

