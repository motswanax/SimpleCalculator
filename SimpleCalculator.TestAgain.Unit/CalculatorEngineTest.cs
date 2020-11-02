using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.TestAgain.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3);
        }

        [TestMethod]
        public void AddsTwoNumbersReturnsValidResultForSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3);
        }
    }
}
