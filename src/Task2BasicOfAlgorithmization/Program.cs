using System;

namespace Task2BasicOfAlgorithmization
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sides = new double[] {6, 8, 10};
            var branches = new BranchesVariant14(sides);
            if(branches.ExistCheck())
            {
                Console.WriteLine("Exist");
                if(branches.TypeCheck())
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
            var strVar5 = new StringVariant5("Ave", "EV");
            if(strVar5.Check())
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
