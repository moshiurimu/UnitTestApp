using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTestApp.Test
{
    class CalculatorTest
    {
        private Calculator aCalculator= new Calculator();




        [Test]
        public void AddTest_Check_If_Can_Add_Two_Positive_Numbers()
        {
            Assert.AreEqual(10, aCalculator.Add(5, 5));
        }


        [Test]
        public void AddTest_Check_If_Can_Add_Two_Negative_Numbers()
        {

            Assert.AreEqual(-10, aCalculator.Add(-5, -5));
        }
        
        
        [Test]
        public void AddTest_Check_If_Can_Add_Two_Double_Positive_Numbers()
        {
            Assert.AreEqual(5,aCalculator.Add(2.5,2.5));
        }


        [Test]
         public void AddTest_Check_If_Can_Add_Two_Double_Negative_Numbers()
        {
            
            Assert.AreEqual(-11,aCalculator.Add(-5.5,-5.5));
        }
    }
}
