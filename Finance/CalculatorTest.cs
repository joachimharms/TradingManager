using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace Finance
{
    [TestFixture]
    public class CalculatorTest
    {
        [TestCase]
        public void GetChanceRiskRatio()
        {
            Assert.AreEqual(10.00M, Calculator.GetChanceRiskRatio());
        }

    }
}
