using System;

namespace TextFileIO
{
	class Program
	{
		static void Main(string[] args)
		{
			SingleFileOperations singleFile = new SingleFileOperations();
			//singleFile.SingleFileOperationsMethod();

			FileSystem fileSystem = new FileSystem();
			fileSystem.FileSystemMethod();
			Console.ReadLine();
		}
	}
}
