using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sum of money: ");
            double cash = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter procent: ");
            double procent = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter sum of months: ");
            double months = Convert.ToDouble(Console.ReadLine());

            double result = deposit(cash, procent, months);
            Console.WriteLine($"Result : {result}");
        }

        static public double deposit(double cash,double procent, double months)
        {
            double result = 0;
            double sum = cash;

            for (int i = 0; i < months; i++)
            {
                result += (cash * (procent / 100)) / 12;
            }
            return result + sum;
        }
    }
}
