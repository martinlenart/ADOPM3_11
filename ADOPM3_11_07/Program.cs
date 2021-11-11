using System;
using System.Reflection;
using System.Collections.Generic;

namespace ADOPM3_11_07
{
	class Program
	{
		static void Main(string[] args)
		{
			Type t1 = DateTime.Now.GetType();        // Type obtained at runtime
			Type t2 = typeof(DateTime);             // Type obtained at compile time
			Type t3 = typeof(DateTime[]);           // 1-d Array type
			Type t4 = typeof(DateTime[,]);			// 2-d Array type
			Type t5 = typeof(Dictionary<int, int>); // Closed generic type
			Type t6 = typeof(Dictionary<,>);        // Unbound generic type

			Console.WriteLine(t1.ToString()); // System.DateTime
			Console.WriteLine(t2.ToString()); // System.DateTime
			Console.WriteLine(t3.ToString()); //System.DateTime[]
			Console.WriteLine(t4.ToString()); //System.DateTime[,]
			Console.WriteLine(t5.ToString()); //System.Collections.Generic.Dictionary`2[System.Int32,System.Int32]
			Console.WriteLine(t6.ToString()); //System.Collections.Generic.Dictionary`2[TKey,TValue]
		}
	}

	//Exercise:
	//1.	Explore the various members of Type using debugger and printout relevant member content
}
