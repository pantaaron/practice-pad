using System;
using System.Collections.Generic;
using PracticePad;

namespace PracticePadConsole
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			var item = new Character {Name = "Bobby"};
			Console.WriteLine(item.Name);
			Console.ReadLine();
		}
	}
}