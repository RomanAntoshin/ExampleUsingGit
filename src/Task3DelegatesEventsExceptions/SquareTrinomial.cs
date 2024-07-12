namespace Task3DelegatesEventsExceptions
{
    class SquareTrinomial
    {
        private static double x;
        public delegate double Del();
        public SquareTrinomial(double X)
        {
            x = X;
        }
        public static double GetValue(double a, double b, double c)
        {
            return a * x * x + b * x + c;
        }
        public static Del GetMethod(double a, double b, double c)
        {
            return () => GetValue(a, b, c);
        }
    }
}
