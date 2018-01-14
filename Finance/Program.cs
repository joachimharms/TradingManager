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
            Console.WriteLine("Geben Sie den Einstiegskurs ein: ");
            Calculator.InitialRate = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie den Stopp - Loss Kurs ein: ");
            Calculator.StoppLoss = decimal.Parse(Console.ReadLine());

            

           


            Console.WriteLine("Geben Sie den Zielkurs ein: ");
            Calculator.TargetRate = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Das Risiko beträgt {Calculator.GetRisk()}");
            Console.WriteLine();

            Console.WriteLine($"Der geplante Gewinn beträgt: {Calculator.GetTargetWinnings()}");
            Console.WriteLine();

            //Console.WriteLine("Geben Sie das Verlustziel ein: ");
            //Calculator.LossTarget = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Das Chance Risiko Verhältnis (CRV) beträg: {Calculator.GetChanceRiskRatio()}");
            Console.WriteLine( );

            Bankroll.BRValueEuro = 100000;
            //Bankroll.GetRiskAmmountEuro(1.5);

            Console.WriteLine("Geben Sie die Höhe der Bankroll in € ein: ");
            Bankroll.BRValueEuro = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie ihren Tradeeinsatz als Prozent von der BR ein: ");
            Bankroll.RiskRatio = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Ihr Einsatz pro Trade beträgt: {Bankroll.GetRiskAmmountEuro()} Euro");

            Console.WriteLine();
            Console.WriteLine("Geben Sie die Anzahl abgeschlossener Trades ein: ");
            Statistic.TradeCounter = int.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie die Anzahl erfolgreicher Trades ein: ");
            Statistic.WinningTradesCounter = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("*****Money-Management Matrix*****");
            Console.WriteLine($"Tradingkonto Bankroll: {Bankroll.BRValueEuro.ToString():C}");
            Console.WriteLine($"Risikobetrag prozentual: {Bankroll.RiskRatio.ToString()} %");
            Console.WriteLine($"Trefferquote: {Statistic.GetHitRate().ToString()} %");
            Console.WriteLine($"Chance-Risiko-Verhältnis: {Calculator.CRV}");
            Console.WriteLine($"Risikobetrag absolut: {Bankroll.GetRiskAmmountEuro().ToString()}");
            Console.WriteLine($"Handelsfrequenz: {Statistic.TradeCounter}");
            Console.WriteLine($"erzielter Gewinn in Euro: {Bankroll.GetRealizedProfit()}");
        }
    }
}
