string location = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

string[] files = Directory.GetFiles(location);

LinkedList<string> assFiles = new LinkedList<string>();

foreach(var file in files)
{
    string fileType = file.Substring(file.Length-4,4);

    if(fileType == ".ASS")
    {
        string endFile = Path.GetFileName(file);

        assFiles.AddLast(endFile);
        
        Console.WriteLine(endFile);
    }
}

string selectedFile = null;

if(assFiles.Count==1)
{
    selectedFile = assFiles.First.Value;
}

if(!assFiles.Any())
{
    Console.WriteLine("No .ASS files found in this directory please add some :3");
    System.Environment.Exit(1);
}

while(selectedFile==null)
{
    Console.WriteLine("Select an ASS program from the above to run");

    string input = Console.ReadLine();

    foreach(var file in assFiles)
    {
        if(string.Compare(file,input)==0)
        {
            selectedFile=file;
            break;
        }
    }
}

Console.WriteLine("running " + selectedFile + "...");