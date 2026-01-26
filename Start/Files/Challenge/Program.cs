// the directory we want to enumerate and results file name

//Project Code
/* Format:
 * ~~~~ Results ~~~~
 * Total Files:
 * Excel Count:
 * Word Count:
 * PowerPoint Count:
 * ----
 * Total Size:
 * Excel Size:
 * Word Size:
 * PowerPoint Size:
 */
const string folder = "FileCollection";
const string resultsfile = "results.txt";

// Variables
long excelCnt = 0; long wordCnt = 0; long ppCnt = 0;
long excelSize = 0; long wordSize = 0; long ppSize  = 0;
long totalFiles = 0; long totalSize = 0;


// Check to see if the file is an office file
bool isOfficeFile(string fileName) {
    if (fileName.EndsWith(".docx") || fileName.EndsWith(".xlsx") || fileName.EndsWith(".pptx")) {
        return true;
    }
    else {
        return false;
    }
}

// create a DirectoryInfo for the given folder
DirectoryInfo dirInfo = new DirectoryInfo(folder);

foreach (FileInfo file in dirInfo.EnumerateFiles()) {
    if (isOfficeFile(file.Name)) {
        totalFiles++;
        totalSize += file.Length;
        if (file.EndsWith(".docx")) {
            wordCnt++;
            wordSize += file.Length;
        }
        if (file.EndsWith(".xlsx")) {
            excelCnt++;
            excelSize += file.Length;
        }
        if (file.EndsWith(".pptx")) {
            ppCnt++;
            ppSize += file.Length;
        }
    }
}
// Output the results
using (StreamWriter sw = File.CreateText(resultsfile)) {
    sw.WriteLine("~~~~ Results ~~~~");
    sw.WriteLine($"Total Files: {totalFiles}");
    sw.WriteLine($"Excel Count: {excelCnt}");
    sw.WriteLine($"Word Count: {wordCnt}");
    sw.WriteLine($"PowerPoint Count: {ppCnt}");
    sw.WriteLine("----");
    sw.WriteLine($"Total Size: {totalSize}");
    sw.WriteLine($"Excel Size: {excelSize}");
    sw.WriteLine($"Word Size: {wordSize}");
    sw.WriteLine($"PowerPoint Size: {ppSize}");
}
