// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Directories

class DirectoryExamples {
    public static void Main() {
        const string dirname = "TestDir";

        CreateOrDeleteDirectory(dirname);
    }

    // TODO: Create a Directory if it doesn't already exist
    public static void CreateOrDeleteDirectory(string testDirName) {
        if (!Directory.Exists(testDirName)) {
            Directory.CreateDirectory(testDirName);
        } else {
            Directory.Delete(testDirName);
        }
        return;
    }

    // TODO: Get the path for the current directory


    // TODO: Just like with files, you can retrieve info about a directory


    // TODO: Enumerate the contents of directories
    // Console.WriteLine("Just directories:");

    // Console.WriteLine("---------------");

    // Console.WriteLine("Just files:");

    // Console.WriteLine("---------------");

    // Console.WriteLine("All directory contents:");

}