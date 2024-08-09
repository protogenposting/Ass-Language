class Data{
    public string name = "name";
    public dynamic value = null;
    public Data() {}
    public Data(string name,dynamic value)
    {
        this.name = name;
        this.value = value;
    }
}

class DoubleData : Data{
    public dynamic corespondingType = typeof(double);
    public DoubleData(string name, double value)
    {
        this.name = name;
        this.value = value;
    }
}