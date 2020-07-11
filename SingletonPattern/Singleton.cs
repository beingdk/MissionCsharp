using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
	/*
	 * Sealed keyword used to prevent inheritance
	 */
	public sealed class Singleton 
	{
		private static Singleton _instance = null;
		private static int counter = 0;
		/*
		 * Using private constructor ensures the class is not instantiated outside this class
		 */
		private Singleton()
		{
			counter++;
			Console.WriteLine("Instance Count " +counter);
		}
		/*
		 * Public property is used to provide only one instance of the class when needed.
		 */
		public static Singleton CreateInstance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new Singleton();
				}
				return _instance; 
			}
		}
		public string SayHeloo()
		{
			return "Hey Dheeraj, I am Singleton";
		}
		public string UserInput(string message)
		{
			return message;
		}
	}
}
