using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
namespace CalculatorTests
{
    [TestClass]
    public class CalculatorUnitTests
    {
        [TestMethod]
        public void TestingAdd()
        {
            Calculator a1 = new Calculator();
            double n1 = -23.452;
            double n2 = -25;
            double expected = n1 + n2;
            double actual = a1.Add(n1, n2);
            Assert.AreEqual(actual, expected, 0, "result is wrong");
            double m1 = Double.MaxValue;
            double m2 = 25;
            Assert.ThrowsException<System.OverflowException>(() => a1.Add(m1, m2));
            double o1 = 23;
            double o2 = Double.MaxValue;
            Assert.ThrowsException<System.OverflowException>(() => a1.Add(o1, o2));
            double p1 = Double.MaxValue;
            double p2 = Double.MaxValue;
            Assert.ThrowsException<System.OverflowException>(() => a1.Add(o1, o2));

        }
        [TestMethod]
        public void TestingSub()
        {
            Calculator a1 = new Calculator();
            double n1 = -23.452;
            double n2 = -25;           
            double expected = n1 - n2;
            double actual = a1.Sub(n1, n2);
            Assert.AreEqual(actual, expected, 0, "result is wrong");
            double o1 = Double.MinValue;
            double o2 = Double.MaxValue;
            Assert.ThrowsException<System.OverflowException>(() => a1.Sub(o1, o2));
            double p1 = Double.MaxValue;
            double p2 = Double.MinValue;
            Assert.ThrowsException<System.OverflowException>(() => a1.Sub(o1, o2));

        }
        [TestMethod]
        public void TestingMul()
        {
            double n1 = -23.452;
            double n2 = -25;
            double expected = n1 * n2;
            Calculator a1 = new Calculator();
            double actual = a1.Mul(n1, n2);
            Assert.AreEqual(actual, expected, 0, "result is wrong");
            n1 = Double.MaxValue;
            n2 = 2;
            Assert.ThrowsException<System.OverflowException>(() => a1.Mul(n1, n2));
            n2 = Double.MaxValue;
            n1 = 2;
            Assert.ThrowsException<System.OverflowException>(() => a1.Mul(n1, n2));
        }
        [TestMethod]
        public void TestingDiv()
        {
            double n1 = -23.452;
            double n2 = 0;
            Calculator a1 = new Calculator();
            Assert.ThrowsException<System.DivideByZeroException>(() => a1.Div(n1,n2));
            
        }

    }
}
