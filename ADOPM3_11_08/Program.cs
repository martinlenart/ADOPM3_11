using System;
using System.IO;
using System.Reflection;

namespace ADOPM3_11_08
{
	class Program
	{
		static void Main(string[] args)
		{
			//Inspect Arrays
			Type e = typeof(int[]).GetElementType();
			Console.WriteLine(e);

			int rank = typeof(int[,,]).GetArrayRank(); 
			Console.WriteLine(rank);

			//Create Array
			Type simpleArrayType = typeof(int).MakeArrayType();
			Console.WriteLine(simpleArrayType == typeof(int[]));  // True

			//Make multidimensional rectangular arrays:
			Type cubeType = typeof(int).MakeArrayType(3); // cube shaped
			Console.WriteLine(cubeType == typeof(int[,,]));  // True

		}
	}
	//Exercise:
	//1. Make a jagged Array using Reflection.
}
