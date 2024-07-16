namespace Task3DelegatesEventsExceptions
{
    class SquareTrinomial
    {
        public delegate double Del(double x);
        public static double GetValue(double a, double b, double c, double x)
        {
            return a * x * x + b * x + c;
        }
        public static Del GetMethod(double a, double b, double c) => (double x) => a * x * x + b * x + c;
    }
}
