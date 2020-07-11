using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TextFileIO
{
	public class FileSystem
	{
		public void FileSystemMethod()
		{
			//string rootPath = @"C:\MissionCsharpIOfiles";
			string rootPath = @"C:\Users\dkumar\Downloads";
			bool rootPathExists = Directory.Exists(rootPath);
			if (rootPathExists)
			{
				//string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
				//foreach (var dir in dirs)
				//{
				//	Console.WriteLine(dir);
				//}
				//Directory.CreateDirectory(@"C:\MissionCsharpIOfiles\Dhiraj_History\Writing_History");
				//string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
				//foreach (var file in files)
				//{
					//Console.WriteLine(file);
					//Console.WriteLine(Path.GetFileName(file));
					//Console.WriteLine(Path.GetFullPath(file));
					//Console.WriteLine(Path.GetDirectoryName(file));
					//Console.WriteLine(Path.GetFileNameWithoutExtension(file));

					//var info = new FileInfo(file);
					//Console.WriteLine($"{info.Name}: {info.Length} bytes");
				//}
				//Directory.CreateDirectory(@"C:\MissionCsharpIOfiles\Dhiraj_History\Writing_History");
				string[] files = Directory.GetFiles(rootPath,"EDI*.*");
				Console.WriteLine($"Total Files: {files.Length}");
				foreach (var file in files)
				{
					//string destinationPath = @"C:\MissionCsharpIOfiles\Dhiraj_History\Trading_History\";
					//File.Copy(file,$"{ destinationPath}{Path.GetFileName(file)}",true);
					//File.Copy(file, $"{ destinationPath}modified.xlsx", true);
					//File.Move(file, $"{ destinationPath}{Path.GetFileName(file)}");
					//}
					//for (int i = 0; i < files.Length; i++)
					//{
					//	string destinationPath = @"C:\MissionCsharpIOfiles\Dhiraj_History\Trading_History\";
					//	File.Copy(files[i], $"{ destinationPath}{i}.txt", true);
					//Console.WriteLine(Path.GetFileName(file));
					//File.Delete(file);
				}
			}
			else
			{
				Console.WriteLine($"Directory Doesn't exists, Directory Name: {rootPath}");
			}
		}
	}
}
