using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
	public class NonSingleton
	{
		private static int counter = 0;
		public NonSingleton()
		{
			counter++;
			Console.WriteLine("Instance Count " + counter);
		}
		public string SayHeloo()
		{
			return "Hey Dheeraj, I am NonSingleton";
		}
	}
}
