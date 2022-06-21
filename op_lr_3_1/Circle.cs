internal class Circle : Circleference
{
    private double Radius;
    Point Center = new();

    public Circle()
    {
        Length = 3.14;
        Radius = 1;
    }
    public void Print()
    {
        Console.WriteLine($"Radius: {Radius} \n" +
            $"Сoordinates of the center: ({Center.X};{Center.Y}) \n" +
            $"Circuit :{Length}");
    }
    public void Setting()
    {
        Console.WriteLine("Parametr setting");
        Console.Write("Radius:");
        Radius = Convert.ToDouble(Console.ReadLine());
        Length = Radius * 2 * Math.PI;
        Console.Write("X coordinate of the center of the circle: ");
        Center.X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y coordinate of the center of the circle: ");
        Center.Y = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
    }
    public void RadiusChange()
    {
        Console.WriteLine("Radius change");
        Radius = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        Print();
    }
    public void PointCheck()
    {
        Point check = new Point();
        Console.Write("X coordinate: ");
        check.X = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y coordinate: ");
        check.Y = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        if (Radius == Math.Sqrt(Math.Pow((check.X + Center.X), 2)) + Math.Pow((check.Y + Center.Y), 2))
        {
            Console.WriteLine($"Point with coordinates X = {check.X}, Y = {check.Y} belong to the circle");
        }
        else
        {
            Console.WriteLine("The point does not belong to the circle");
        }
    }
    public override bool Equals(object? obj)
    {
        Circle c = obj as Circle;
        if (c == null|| obj == null)
            return false;
        return c.Radius == Radius && c.Center == Center;       
    }
    public override int GetHashCode()
    {
        return Convert.ToInt32((Center.Y + Center.X + Radius)*10);
    }
    public override string ToString()
    {
        return base.ToString() + $"{Radius} {Center.X} {Center.Y}";
    }
}