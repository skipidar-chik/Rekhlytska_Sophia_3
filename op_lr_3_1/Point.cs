internal class Point
{
    public double X;
    public double Y;
    public Point()
    {
        X = 0;
        Y = 0;
    }
    public override int GetHashCode()
    {
        return Convert.ToInt32(Math.Abs((X + Y) * 1000));
    }
    public override bool Equals(object? obj)
    {
        Point p = obj as Point;

        if (p == null|| obj == null)
            return false;
        return p.X == X && p.Y == Y;
    }
    public override string ToString()
    {
        return base.ToString() + $": {X} {Y}";
    }       
        
}