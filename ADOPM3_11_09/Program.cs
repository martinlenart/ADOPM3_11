using System;
using System.Reflection;


namespace ADOPM3_11_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nested Types
            foreach (Type t in typeof(System.Environment).GetNestedTypes())
                Console.WriteLine(t.FullName);

            // The CLR treats a nested type as having special “nested” accessibility levels:
            Console.WriteLine();
            Type sf = typeof(System.Environment.SpecialFolder);
            Console.WriteLine(sf.IsPublic);                      // False
            Console.WriteLine(sf.IsNestedPublic);                // True   

            //BaseTypes and Interfaces
            Console.WriteLine();
            Type base1 = typeof(System.String).BaseType;
            Type base2 = typeof(System.IO.FileStream).BaseType;

            Console.WriteLine(base1.Name);     // Object
            Console.WriteLine(base2.Name);     // Stream

            Console.WriteLine();

            foreach (Type iType in typeof(Guid).GetInterfaces())
                Console.WriteLine(iType.Name);  // IFormatable, IComparable,...
        }
    }

    //Exercise:
    //1.    Explore the various members of the Nested type. 
    //2     Create your own class type with nested members, basetype and interfaces.  Explore it through reflection
}
