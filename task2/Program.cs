class Program {
    static void Main(String[] args)
    {
        Console.WriteLine("Пользователь, введи два числа, представляющие стороны прямоугольника, каждое с новой строки");
        double sideA = Convert.ToDouble(Console.ReadLine());
        double sideB = Convert.ToDouble(Console.ReadLine());

        Rectangle ob = new(sideA, sideB);
        Console.WriteLine($"Периметр: {ob.Area}, Площадь: {ob.Perimeter}");
    }
}

public class Rectangle
{
    double sideA = 0;
    double sideB = 0;
    public Rectangle(double sideA, double sideB)
    {
        this.sideA = sideA;
        this.sideB = sideB;
    }
    private double CalculateArea()
    {
        return sideA * sideB;
    }
    private double CalculatePerimeter()
    {
        return 2 * (sideA + sideB);
    }

    public double Area { get { return CalculateArea(); } }
    public double Perimeter { get { return CalculatePerimeter(); } }

}
