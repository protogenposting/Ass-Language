namespace AssCompiler
{
    class ProgramRunner
    {
        static string getFile()
        {
            //this prevents vs code from giving a warning on certain thingamabobs
            #pragma warning disable

            //get the exe's location
            string location = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            //get the files of the directory
            string[] files = Directory.GetFiles(location);

            //the assFiles list stores all the ass files we found
            LinkedList<string> assFiles = new LinkedList<string>();

            //this loop searches through all the files and finds and .ASS files
            foreach (var file in files)
            {
                string fileType = file.Substring(file.Length - 4, 4);

                if (fileType == ".ASS")
                {
                    string endFile = Path.GetFileName(file);

                    assFiles.AddLast(endFile);

                    Console.WriteLine(endFile);
                }
            }

            //selected file is the return value :3
            string selectedFile = null;

            //if there's only 1 file then return the only one
            if (assFiles.Count == 1)
            {
                selectedFile = assFiles.First.Value;
            }

            //if there are no files just end the program after 5 seconds lol
            if (!assFiles.Any())
            {
                Console.WriteLine("No .ASS files found in this directory please add some :3");
                Thread.Sleep(5000);
                System.Environment.Exit(1);
            }

            //repeat this until the user selects an actual file
            while (selectedFile == null)
            {
                Console.WriteLine("Select an ASS program from the above to run");

                string input = Console.ReadLine();

                foreach (var file in assFiles)
                {
                    if (string.Compare(file, input) == 0)
                    {
                        selectedFile = file;
                        break;
                    }
                }
            }

            Console.WriteLine("running " + selectedFile + "...");

            Console.WriteLine("--------------------------------");

            return selectedFile;
        }

        static void runAssProgram(LinkedList<string> programLines)
        {
            LinkedList<Data> variables = new LinkedList<Data>();
            //tokenize them strings
            foreach (var line in programLines)
            {
                string newLine = line;

                //remove all the tabs lol
                line.Replace("\t","");
                
                int slashLocation = line.IndexOf("//");
                if(slashLocation == 0)
                {
                    Console.WriteLine(line);
                    continue;
                }
            }
        }
        static void Main()
        {
            LinkedList<string> fileLines = new LinkedList<string>();

            var fileReader = new StreamReader(getFile());

            var line = fileReader.ReadLine();

            while (line != null)
            {
                fileLines.AddLast(line);

                line = fileReader.ReadLine();
            }

            runAssProgram(fileLines);
        }
    }
}

