using System;
using System.IO;
namespace Task2BasicOfAlgorithmization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First task:");
            double[] sides = new double[] { 1, 1, 2 };
            var branches = new BranchesVariant14(sides);
            if (branches.ExistCheck())
            {
                Console.WriteLine("Exist");
                if (branches.TypeCheck())
                {
                    Console.WriteLine("Sharp - angled");
                }
                else
                {
                    Console.WriteLine("Not sharp - angled");
                }
            }
            else
            {
                Console.WriteLine("Not exist");
            }
            Console.WriteLine("Second task:");
            var variants = CyclesVariant5.GetAnimalsCount(64);
            foreach (var el in variants)
            {
                Console.WriteLine(el.Rabbit + " - rabit " + el.Goose + " - goose");
            }
            Console.WriteLine("Third task");
            StringVariant5 strVar5;
            using (StreamReader reader = new StreamReader("INPUT.txt"))
            {
                strVar5 = new StringVariant5(reader.ReadLine());
                reader.Close();
            }
            using (var writer = new StreamWriter("OUTPUT.txt"))
            {
                if (strVar5.Check())
                {
                    writer.Write("Yes");
                }
                else
                {
                    writer.Write("No");
                }
                writer.Close();
            }
            Console.WriteLine("Result in file OUTPUT.txt");
            Console.WriteLine("Fourth task");
            string[] names = { "Алина", "Анна", "Валерия", "Дарья", "Ксения", "Мария", "Нелли", "Ольга", "Полина", "Рина", "Светлана", "Татьяна", "Ульяна", "Федора" };
            string[][] namesOfClasses = new string[4][];
            namesOfClasses[0] = new string[] { "Ксения", "Елизавета", "Ангелина", "Дарья", "Алина", "Рина" };
            namesOfClasses[1] = new string[] { "Ксения", "Ольга", "Дарья", "Дарья", "Полина" };
            namesOfClasses[2] = new string[] { "Ксения", "Нелли", "Евгения", "Дарья", "Полина" };
            namesOfClasses[3] = new string[] { "Ксения", "Алена", "Дарья" };
            var data = SetsVariant2.Check(names, namesOfClasses);
            foreach (var el in data)
            {
                if (el.Count == namesOfClasses.Length)
                {
                    Console.WriteLine(el.Name + " встречается во всех классах параллели");
                }
                if (el.Count < namesOfClasses.Length & el.Count > 0)
                {
                    Console.WriteLine(el.Name + " встречается в некоторых классах параллели");
                }
                if (el.Count == 0)
                {
                    Console.WriteLine(el.Name + " не встречается ни в одном классе параллели");
                }
            }
            Console.WriteLine("Fiveth task");
            DateTime[] dates = new DateTime[5];
            dates[0] = new DateTime(2015, 7, 3);
            dates[1] = new DateTime(2024, 7, 4, 23, 59, 59);
            dates[2] = new DateTime(2024, 4, 1);
            dates[3] = new DateTime(2023, 12, 13);
            dates[4] = new DateTime(2024, 7, 4, 22, 31, 48);
            var variant11 = new DatesVariant11(dates);
            Console.WriteLine(variant11.GetNearestDate(DateTime.Now.Date));
            Console.WriteLine("Sixth task");
            DataStructuresVariant7<int> stack = new DataStructuresVariant7<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine(stack.Peek());
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
