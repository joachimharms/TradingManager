using System;
using System.Net.Http.Headers;

namespace Finance
{
    public static class Calculator
    {
        #region Properties

        // Gewinnziel in € - Wieviel Gewinn soll der Trade bringen (wenn erfolgreich): 
        private static decimal profitTarget;
        
        public static decimal ProfitTarget
        {
            get { return profitTarget; }
            set { profitTarget = value; }
        }

        private static decimal lossTarget;

        public static decimal LossTarget
        {
            get { return lossTarget; }
            set { lossTarget = value; }
        }

        // Risiko - Maximalbetrag der verloren werden kann, wenn Stopp-Loss eingehalten wird.
        public static decimal Risk { get; set; }
        
        // Einstiegskurs
        public static decimal InitialRate { get; set; }

        // Stopp-Loss Kurs
        public static decimal StoppLoss { get; set; }

        // Zielkurs
        public static decimal TargetRate { get; set; }

        // Chance-Risiko Verhältnis sollte immer über 1 sein. Am besten 1.5 - 2
        // Einige Trader gehen auch nur ein CRV von 3, 4 oder 5 ein. Also todsichere Geschäfte.
        // Trades mit CRV < 1 sollten vermieden werden.
        public static decimal CRV { get; set; }

        #endregion


        #region Methods


        public static decimal GetChanceRiskRatio()
        {
            //if (LossTarget != 0.00M)
            //{
            //    ProfitTarget = Risk;
            //    LossTarget = GetTargetWinnings(); 
            //    return ProfitTarget/ LossTarget;
            //}

            //Console.WriteLine("Es darf nicht durch Null geteilt werden!");
            //return -1;
            CRV = ProfitTarget / Risk;
            return CRV;
        }

        public static decimal GetRisk()
        {
            Risk = InitialRate - StoppLoss;
            return Risk;
        }

        public static decimal GetTargetWinnings()
        {
            ProfitTarget = TargetRate - InitialRate;
            return ProfitTarget;
        }

        

        #endregion
    }
}