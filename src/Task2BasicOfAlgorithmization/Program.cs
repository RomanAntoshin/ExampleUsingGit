using System;

namespace Task2BasicOfAlgorithmization
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sides = new double[] { 6, 8, 10 };
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
            CyclesVariant5.GetAnimalsCount(64);
            var strVar5 = new StringVariant5("E:\\Git\\STM_labs_Practice\\STM_labs_Practice\\src\\Task2BasicOfAlgorithmization\\INPUT.txt");
            strVar5.CheckAndWrite();
            string[] names = { "Алина", "Анна", "Валерия", "Дарья", "Ксения", "Мария", "Нелли", "Ольга", "Полина", "Рина", "Светлана", "Татьяна", "Ульяна", "Федора" };
            string[][] namesOfClasses = new string[4][];
            namesOfClasses[0] = new string[] { "Ксения", "Елизавета", "Ангелина", "Дарья", "Алина", "Рина" };
            namesOfClasses[1] = new string[] { "Ксения", "Ольга", "Дарья", "Дарья", "Полина" };
            namesOfClasses[2] = new string[] { "Ксения", "Нелли", "Евгения", "Дарья", "Полина" };
            namesOfClasses[3] = new string[] { "Ксения", "Алена", "Дарья" };
            SetsVariant2.Check(names, namesOfClasses);
            DateTime[] dates = new DateTime[5];
            dates[0] = new DateTime(2015, 7, 3);
            dates[1] = new DateTime(2024, 7, 1);
            dates[2] = new DateTime(2024, 4, 1);
            dates[3] = new DateTime(2023, 12, 13);
            dates[4] = new DateTime(2024, 7, 4);
            var variant11 = new DatesVariant11(dates);
            Console.WriteLine(variant11.GetNearestDate(DateTime.Now.Date).Date);
        }
    }
}
