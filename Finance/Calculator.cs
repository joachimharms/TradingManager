using System;

namespace Finance
{
    public static class Calculator
    {
        #region Properties

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

        public static decimal Risk { get; set; }
        public static decimal InitialRate { get; set; }
        public static decimal StoppLoss { get; set; }
        public static decimal TargetRate { get; set; }



        #endregion


        #region Methods


        public static decimal GetChanceRiskRatio()
        {
            if (LossTarget != 0.00M)
            {
                return ProfitTarget / LossTarget;
            }

            Console.WriteLine("Es darf nicht durch Null geteilt werden!");
            return -1;

        }

        public static decimal GetRisk()
        {
            return InitialRate - StoppLoss;
        }

        public static decimal GetTargetWinnings()
        {
            return TargetRate - InitialRate;
        }

        #endregion
    }
}