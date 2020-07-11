using System;
using System.Threading.Tasks;

namespace SingletonPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			NonSingleton ns1 = new NonSingleton();
			Console.WriteLine(ns1.SayHeloo());
			NonSingleton ns2 = new NonSingleton();
			Console.WriteLine(ns2.SayHeloo());
			if (ns1 != ns2)
			{
				Console.WriteLine("We are not equal");
			}

			Console.WriteLine("=====================================================");

			Singleton s1 = Singleton.CreateInstance;
			Console.WriteLine(s1.SayHeloo());
			Singleton s2 = Singleton.CreateInstance;
			Console.WriteLine(s2.SayHeloo());
			if (s1 == s2)
			{
				Console.WriteLine("We are equal");
			}

			Console.WriteLine("=====================================================");

			Parallel.Invoke(
				() => DumbMethod(),
				() => SmartMethod()
				);
		}

		private static void DumbMethod()
		{
			Singleton s1 = Singleton.CreateInstance;
			Console.WriteLine(s1.UserInput("I am Dumb"));
		}
		private static void SmartMethod()
		{
			Singleton s1 = Singleton.CreateInstance;
			Console.WriteLine(s1.UserInput("I am Dumb"));
		}
	}
}