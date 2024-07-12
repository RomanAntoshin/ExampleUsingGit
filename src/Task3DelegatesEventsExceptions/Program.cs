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
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(day());
            }
            SquareTrinomial trinomial = new SquareTrinomial(10);
            var del = SquareTrinomial.GetMethod(0, 2, 3);
            Console.WriteLine(del());
            LimitedStringLoader limited = new LimitedStringLoader("ABC", "DEF", 2);
            limited.Load("INPUT.txt");
            foreach(var el in limited.Data)
            {
                Console.WriteLine(el);
            }
            var first = new ClassWithEvent("First");
            var second = new ClassWithEvent("Second");
            var listener = new Listener();
            //first += listener.Method;
            first.AddHandler(listener.Method);
            second.AddHandler(listener.Method);
            first.GenerateEvent();
            second.GenerateEvent();

            //Console.WriteLine(SquareTrinomial.GetMethod(1, 2, 3));
        }
    }
}
