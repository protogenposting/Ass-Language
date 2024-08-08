string location = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

string[] files = Directory.GetFiles(location);

string[] assFiles = {};

foreach(var file in files)
{
    string fileType = file.Substring(file.Length-4,4);

    if(fileType == ".ASS")
    {
        string endFile = Path.GetFileName(file);

        assFiles.Append(endFile);
        
        Console.WriteLine(endFile);
    }
}

string selectedFile = null;

while(selectedFile==null)
{
    Console.WriteLine("Select an ASS program from the above to run");

    string input = Console.ReadLine();

    foreach(var file in assFiles)
    {
        Console.WriteLine(input);
        Console.WriteLine(file);
        if(string.Compare(file,input)==1)
        {
            selectedFile=file;
            break;
        }
    }
}

Console.WriteLine("running " + selectedFile + "...");