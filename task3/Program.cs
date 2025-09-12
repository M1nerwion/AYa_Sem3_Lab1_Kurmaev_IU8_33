class Program
{
    static void Main(String[] args)
    {
        //Console.WriteLine("Пользователь, введи два числа, представляющие стороны прямоугольника, каждое с новой строки");
        Point a = new(0, 0);
        Point b = new(0, 5);
        Point c = new(5, 5);
        //Point d = new(5, 0);
        //Point e = new(1, 1);
        //Figure ob = new(a, b, c, d, e);
        Figure ob = new(a, b, c);


        Console.WriteLine($"Имя: {ob.Name}, Периметр: {ob.PerimeterCalculator()}");
    }
}

public class Point {
    int x;
    int y;
    
    public int X { get { return x; } }
    public int Y { get { return y; } }

    public Point(int x = 0, int y = 0)
    {
        this.x = x;
        this.y = y;
    }
}
public class Figure {
    Point[] points;
    public string Name { get; set; } = "Undefined";
    public int Count { get; set; } = 0;

    public Figure(Point A, Point B, Point C)
    {
        points = new Point[5];
        points[0] = A;
        points[1] = B;
        points[2] = C;
        Count = 3;
        Name = "Треугольник";
    }
    public Figure(Point A, Point B, Point C, Point D) : this(A, B, C)
    {
        points[3] = D;
        Count = 4;
        Name = "Четырёхугольник";
    }

    public Figure(Point A, Point B, Point C, Point D, Point E) : this(A, B, C, D)
    {
        points[4] = E;
        Count = 5;
        Name = "Пятиугольник";
    }

    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
    }

    public double PerimeterCalculator()
    {
        double sum = 0;

        for (int i = 0; i < (Count-1); i++)
        {
            sum += LengthSide(points[i], points[i + 1]);
        }
        sum += LengthSide(points[Count-1], points[0]);
        return sum;
    }
}
