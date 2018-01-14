#region License
// Copyright (c) 2017, Joachim Harms
// All rights reserved.
// 
// Unauthorized copying of this file, via any medium is strictly prohibited.
// Proprietary and confidential.
// 
// Written by Joachim Harms
// <joachimharms.business@gmail.com>
#endregion

using System;

namespace Finance
{
    public static class Bankroll
    {
        public static decimal BRValueEuro { get; set; }

        public static decimal BRValueBTC { get; set; }

        public static decimal RiskRatio { get; set; }

        public static decimal RealizedProfit { get; set; }

        public static decimal ExpectedValue { get; set; }
        #region Methods

        public static decimal GetRiskAmmountEuro()
        {
          
            return RiskRatio * BRValueEuro / 100;
        }

        public static decimal GetRealizedProfit()
        {
            decimal loss = (Statistic.TradeCounter - Statistic.WinningTradesCounter) * Bankroll.GetRiskAmmountEuro();
            decimal win = Statistic.WinningTradesCounter * (Bankroll.GetRiskAmmountEuro() * Calculator.CRV);
            RealizedProfit = win - loss;
            return RealizedProfit;

        }

        public static decimal GetExpectedValuePerTrade()
        {
             throw new NotImplementedException();
        }

        #endregion
    }
}