// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Directories

// TODO: Get the path for the current directory

string dirPath = Directory.GetCurrentDirectory();
Console.WriteLine($"Current directory is {dirPath}");

// TODO: Just like with files, you can retrieve info about a directory

DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
Console.WriteLine(dirInfo.Name);
Console.WriteLine(dirInfo.Parent);
Console.WriteLine(dirInfo.CreationTime);

// TODO: Enumerate the contents of directories

Console.WriteLine("Just directories:");
List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirPath));
foreach (string dir in dirs)
{
    Console.WriteLine(dir);
}
Console.WriteLine("---------------");

Console.WriteLine("Just files:");
List<string> files = new List<string>(Directory.EnumerateFiles(dirPath));
foreach (string file in files)
{
    Console.WriteLine(file);
}
Console.WriteLine("---------------");

Console.WriteLine("All directory contents:");
List<string> contents = new List<string>(Directory.EnumerateFileSystemEntries(dirPath));
foreach (string dir2 in contents)
{
    Console.WriteLine(dir2);
}
