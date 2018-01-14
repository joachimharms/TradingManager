using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework.Constraints;

namespace Finance
{
    static class Statistic
    {
        #region Properties
        public static int WinningTradesCounter { get; set; }

        public static int TradeCounter { get; set; }

        // Trefferquote
        public static double HitRate { get; set; }
        #endregion
        #region Methods

        // Trefferquote - prozentualer Anteil der gewonnen Trades
        public static double GetHitRate()
        {
            HitRate = (double)WinningTradesCounter/ (double)TradeCounter * 100;
            return HitRate;
        }
        

        #endregion
    }


}
