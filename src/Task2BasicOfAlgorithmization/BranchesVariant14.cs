using System;
using System.Linq;

namespace Task2BasicOfAlgorithmization
{
    public class BranchesVariant14
    {
        private double[] sides;
        public BranchesVariant14(double[] sides)
        {
            try
            {
                if(sides.Length!=3)
                {
                    throw new Exception("Invalid data");
                }
                this.sides = sides;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
        public bool ExistCheck()
        {

            try
            {
                if(sides==null)
                {
                    //throw new Exception("Null data");
                    throw new NullReferenceException();
                }
                for (int i = 0; i < sides.Length; i++)
                {
                    if (sides[i] <= 0)
                    {
                        return false;
                    }
                }
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
            catch(NullReferenceException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
        }
        public bool TypeCheck()
        {
            /*if(!ExistCheck())
            {
                throw new Exception("Invalid data");
            }*/
            try
            {
                if (!ExistCheck())
                {
                    throw new Exception("This triangle is not exist");
                }
                double partSumSquare = 0;
                for (int i = 0; i < sides.Length - 1; i++)
                {
                    partSumSquare += Math.Pow(sides[i], 2);
                }
                return Math.Pow(sides[sides.Length - 1], 2) < partSumSquare;
            }
            catch(Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
                throw;
            }

            /*if (Math.Pow(sides[sides.Length - 1], 2) < partSumSquare)
            {
                return true;
            }
            else
            {
                return false;
            }*/
        }
    }
}
