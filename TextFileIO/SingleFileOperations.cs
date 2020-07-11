using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace TextFileIO
{
	public class SingleFileOperations
	{
		public void SingleFileOperationsMethod()
		{
			string filePath = @"C:\MissionCsharpIOfiles\Peoples.txt";

			//List<string> lines = File.ReadAllLines(filePath).ToList();

			//lines.Add("Chandru,Sekar,He is a sniper Trader");
			//File.WriteAllLines(filePath,lines);
			//foreach (var line in lines)
			//{
			//	Console.WriteLine(line);
			//}
			List<Person> peoples = new List<Person>();
			List<string> lines = File.ReadAllLines(filePath).ToList();
			foreach (var line in lines)
			{
				Person newPerson = new Person();
				string[] entries = line.Split(',');
				newPerson.FirstName = entries[0];
				newPerson.LastName = entries[1];
				newPerson.Description = entries[2];

				peoples.Add(newPerson);
			}
			//peoples.Add(new Person { FirstName = "Dhiraj", LastName = "Kumar", Description = "He is an Elite Trader" });
			//peoples.Add(new Person { FirstName = "Ajay", LastName = "Gupta", Description = "He is an Algo Trader" });
			List<string> output = new List<string>();
			foreach (var people in peoples)
			{
				//output.Add($"{people.FirstName},{people.LastName},{people.Description}");

				Console.WriteLine($"{people.FirstName} {people.LastName}: {people.Description}");
			}
			//File.WriteAllLines(filePath, output);
		}
	}
}
