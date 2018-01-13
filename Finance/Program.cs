using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Finance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie das Gewinnziel ein: ");
            Calculator.ProfitTarget = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie das Verlustziel ein: ");
            Calculator.LossTarget = decimal.Parse(Console.ReadLine());

            Console.WriteLine(Calculator.GetChanceRiskRatio());

            Console.WriteLine("Geben Sie den Einstiegskurs ein: ");
            Calculator.InitialRate = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie den Stopp - Loss Kurs ein: ");
            Calculator.StoppLoss = decimal.Parse(Console.ReadLine());

            Console.WriteLine(Calculator.GetRisk());

            

        }
    }
}
