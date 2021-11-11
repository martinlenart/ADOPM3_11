using System;
using System.Reflection;
using System.Resources;

namespace ADOPM3_11_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(Program).Assembly.GetName()); // Example8_06....
            Console.WriteLine(typeof(Program).Assembly.GetName().Version); // 1.0.0.0 
            Console.WriteLine(typeof(Program).Assembly.GetName().CodeBase); // ...file:///C:/Users/marti/Development/Vi...

            ResourceManager rm = new ResourceManager("Example8_06.Properties.Resources", Assembly.GetExecutingAssembly());

            Console.WriteLine(rm.GetString("String1")); // myString
            Console.WriteLine(rm.GetString("String2")); // myOtherString
        }
    }
}
