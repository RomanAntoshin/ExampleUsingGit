namespace Task3DelegatesEventsExceptions
{
    class SquareTrinomial
    {
        public delegate double Del(double x);
        public static Del GetMethod(double a, double b, double c) => (double x) => a * x * x + b * x + c;
    }
}
