namespace Task4
{
    public class Program
    {
        public static void Main(string[] args) { }
        public static bool IsValidTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 &&
                   a + b > c && a + c > b && b + c > a;
        }

        public static double GetPerimeter(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
                throw new ArgumentException("Неправильний трикутник");
            return a + b + c;
        }

        public static double GetArea(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
                throw new ArgumentException("Неправильний трикутник");

            double p = GetPerimeter(a, b, c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static string GetTriangleType(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
                throw new ArgumentException("Неправильний трикутник");

            if (a == b && b == c) return "рівносторонній";
            if (a == b || a == c || b == c) return "рівнобедрений";
            if (Math.Abs(a * a + b * b - c * c) < 0.001 ||
                Math.Abs(a * a + c * c - b * b) < 0.001 ||
                Math.Abs(b * b + c * c - a * a) < 0.001)
                return "прямокутний";
            return "довільний";
        }
    }
}