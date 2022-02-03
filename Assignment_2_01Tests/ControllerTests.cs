using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_2_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_01.Tests
{
    [TestClass()]
    public class ControllerTests
    {
        [TestMethod()]

        public void makeDeposit()
        {
            //Arrange
            Controller c = new Controller();
            double balance = 100.00;
            double value = 50.00;

            //Act
            c.deposit(value, balance);

            //Assert
            double expected = 150.00;
            double actual = balance + value;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void MakeWithdrawal()
        {
            //Arrange
            Controller c = new Controller();
            double balance = 100.00;
            double value = 50.00;

            //Act
            c.withdrawal(value, balance);

            //Assert
            double expected = 50.00;
            double actual = balance - value;
            Assert.AreEqual(expected, actual);

        }


        [TestMethod()]
        public void failedWithdrawal()
        {
            //Arrange 
            Controller c = new Controller();
            double balance = 100.00;
            double value = 50.00;

            //Act
            bool failed = c.failedWithdrawal(value, balance);

            //Assert

            Assert.IsFalse(failed);

        }
    }
}
