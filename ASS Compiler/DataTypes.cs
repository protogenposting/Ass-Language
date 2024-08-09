class Data{
    public string name = "name";
    public Data() {}
    public Data(string name)
    {
        this.name = name;
    }
}

class DoubleData : Data{
    public double value = 0;
    public dynamic corespondingType = typeof(double);
    public DoubleData(string name, double value)
    {
        this.name = name;
        this.value = value;
    }
}