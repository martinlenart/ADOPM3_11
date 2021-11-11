using System;
using System.Reflection;

namespace ADOPM3_11_10
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = Guid.NewGuid();
            Type target = typeof(IFormattable);

            bool isTrue = obj is IFormattable;             // Static C# operator
            bool alsoTrue = target.IsInstanceOfType(obj);   // Dynamic equivalent

            Console.WriteLine(isTrue); // true
            Console.WriteLine(alsoTrue); // true

            Type target2 = typeof(IComparable), source = typeof(string);
            Console.WriteLine(target2.IsAssignableFrom(source));         // true
            Console.WriteLine(target2.IsSubclassOf(source));             // false

            Type base1 = typeof(System.String).BaseType;
            Console.WriteLine(typeof(System.String).IsSubclassOf(base1)); // True
        }
    }
    //Exercises:
    //1.    Create your own class type with nested memebers and basetype. Create an instance of the class and explore
    //      IsInstanceOfType, IsAssignableFrom, IsSubclassOf. Compare it with is and as operators
}
