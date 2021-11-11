using System;
using System.Reflection;

namespace ADOPM3_11_12
{
    class Program
    {
        class Walnut
        {
            public bool cracked;
            public void CrackIt() { cracked = true; }
            public void Crack() { cracked = false; }
        }
        static void Main(string[] args)
        {
            MemberInfo[] members = typeof(Walnut).GetMembers();
            foreach (MemberInfo m in members)
                Console.WriteLine(m);

            Walnut walnut = new Walnut();
            FieldInfo fi = typeof(Walnut).GetField("cracked");
            fi.SetValue(walnut, true);
            Console.WriteLine(walnut.cracked); // true

            fi.SetValue(walnut, false);
            Console.WriteLine(walnut.cracked); // false

            MethodInfo mi = walnut.GetType().GetMethod("CrackIt");
            mi.Invoke(walnut, null);

            Console.WriteLine(walnut.cracked); // true
        }
    }

    //Exercise:
    //1.    Create a method Size(int size) that takes an argument to give the walnut a size. Set the size via reflection
    //2.    Access GetFields() and GetMethods() and enumerate the members to see the from exercise 1 created field and method
}
