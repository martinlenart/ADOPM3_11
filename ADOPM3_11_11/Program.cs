using System;
using System.Reflection;

namespace ADOPM3_11_11
{
    class Program
    {
        public class Person
        {
            public string Message { get; set; }
            public string Name { get; set; }
            public DateTime Born { get; set; }

            public Person(string Name) { this.Name = Name; }
            public Person(string Name, DateTime Born) { this.Name = Name; this.Born = Born; }
        }
   
        static void Main(string[] args)
        {
            int i = (int)Activator.CreateInstance(typeof(int));
            i = 3;
            Console.WriteLine(i);

            DateTime dt = (DateTime)Activator.CreateInstance(typeof(DateTime), 2000, 1, 1);
            Console.WriteLine(dt);

            // Fetch the constructor that accepts a single parameter of type string:
            ConstructorInfo ci1 = typeof(Person).GetConstructor(new[] { typeof(string) });

            // Construct the object using the correct overload:
            object o1 = ci1.Invoke(new object[] { "Alice" });
            Person p1 = o1 as Person;
            Console.WriteLine(p1.Name);

            ConstructorInfo ci2 = typeof(Person).GetConstructor(new[] { typeof(string), typeof(DateTime) });
            object o2 = ci2.Invoke(new object[] { "John", new DateTime(1980,3,5)});
            Person p2 = o2 as Person;
            Console.WriteLine(p2.Name);
        }
    }
    //Exercises:
    //1.    Create your own class type and instanciate it using reflection
    //2.    Create a jagged array using reflection. Instantiate it using reflection
}
