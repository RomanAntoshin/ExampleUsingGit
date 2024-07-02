using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2BasicOfAlgorithmization
{
    public class BranchesVariant14
    {
        private double[] sides;
        public BranchesVariant14(double[] sides)
        {
            this.sides = sides;
        }
        public bool ExistCheck()
        {
            Array.Sort(sides);
            if (sides.Take(sides.Length - 1).Sum() <= sides[sides.Length - 1])
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool TypeCheck()
        {
            double partSumSquare = 0;
            for(int i=0; i<sides.Length-1; i++)
            {
                partSumSquare += Math.Pow(sides[i], 2);
            }
            if(Math.Pow(sides[sides.Length-1], 2)<partSumSquare)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
