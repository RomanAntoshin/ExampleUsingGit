using System;

namespace Task3DelegatesEventsExceptions
{
    class Program
    {
        delegate string Day();
        delegate double Calc(double x, double y);
        //delegate double Del(double a, double b, double c);
        static void Main(string[] args)
        {
            Calc calculator = Calculator.Sum;
            Console.WriteLine(calculator?.Invoke(1, 8));
            calculator -= Calculator.Sum;
            calculator += Calculator.Diff;
            Console.WriteLine(calculator?.Invoke(1, 8));
            calculator -= Calculator.Diff;
            calculator += Calculator.Multiply;
            Console.WriteLine(calculator?.Invoke(1, 8));
            calculator -= Calculator.Multiply;
            calculator += Calculator.Division;
            Console.WriteLine(calculator?.Invoke(1, 8));
            Day day=()=> DaysOfWeek.GetDay();
            for (int i=0; i<10; i++)
            {
                Console.WriteLine(day());
            }
            SquareTrinomial trinomial = new SquareTrinomial(10);
            var del = SquareTrinomial.GetMethod(0, 2, 3);
            Console.WriteLine(del());
            LimitedStringLoader limited = new LimitedStringLoader("EABC", "CDE", 0);
            //Console.WriteLine(SquareTrinomial.GetMethod(1, 2, 3));
        }
    }
}
