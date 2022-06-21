internal abstract class Circleference
    {
    protected double Length { get; set; }
    public Circleference()
    {
        Length = 1;
    }
    public override bool Equals(object? obj)
    {
        Circleference c = obj as Circleference;
        if (c == null || obj == null) 
            return false;
        return c.Length == Length;
    }
    public override int GetHashCode()
    {
        return Convert.ToInt32(Math.PI * 1000);
    }
    public override string ToString()
    {
        return base.ToString() + $": {Length}";
    }
}
