namespace AssCompiler
{
    class Keyword
    {
        public string name = "name";
        public Keyword(string name)
        {
            this.name=name;
        }
    }
    class Keywords
    {
        public static Keyword[] keywords = {
            new Keyword("var")
        };
        public static Keyword FindKeyword(string line)
        {
            foreach(var i in keywords)
            {
                if(i.name==line.Substring(0,i.name.Length))
                {
                    return i;
                }
            }
            return null;
        }
        public static void keywordVar(string variableName, string value, LinkedList<Data> variables)
        {
            if (double.TryParse(value, out double n))
            {
                double variableValue = double.Parse(value);

                variables.AddLast(new DoubleData(variableName, variableValue));
            }
        }
    }
}