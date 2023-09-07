using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pract1_Create_a_password_field_check_on;
using System;
using System.Collections.Generic;

namespace Create_a_password_field_check_on.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_of_all_conditions_0retun()
        {
            // Arrange
            string password = "";
            int expected = 0;

            // Act
            password_field_check validator = new password_field_check();
            int passedChecks = validator.Passed_Checks(password);
            // Assert
            Assert.AreEqual(expected, passedChecks);
        }
        [TestMethod]
        public void Test_of_all_conditions_1retun()
        {
            // Arrange
            string password = "1";
            int expected = 1;

            // Act
            password_field_check validator = new password_field_check();
            int passedChecks = validator.Passed_Checks(password);
            // Assert
            Assert.AreEqual(expected, passedChecks);
        }
        [TestMethod]
        public void Test_of_all_conditions_2retun()
        {
            // Arrange
            string password = "2raza";
            int expected = 2;

            // Act
            password_field_check validator = new password_field_check();
            int passedChecks = validator.Passed_Checks(password);
            // Assert
            Assert.AreEqual(expected, passedChecks);
        }
        [TestMethod]
        public void Test_of_all_conditions_3retun()
        {
            // Arrange
            string password = "3Good";
            int expected = 3;

            // Act
            password_field_check validator = new password_field_check();
            int passedChecks = validator.Passed_Checks(password);
            // Assert
            Assert.AreEqual(expected, passedChecks);
        }
        [TestMethod]
        public void Test_of_all_conditions_4retun()
        {
            // Arrange
            string password = "4sdf-sdff";
            int expected = 4;

            // Act
            password_field_check validator = new password_field_check();
            int passedChecks = validator.Passed_Checks(password);
            // Assert
            Assert.AreEqual(expected, passedChecks);
        }
        [TestMethod]
        public void Test_of_all_conditions_5retun()
        {
            // Arrange
            string password = "5Piplov!10";
            int expected = 5;

            // Act
            password_field_check validator = new password_field_check();
            int passedChecks = validator.Passed_Checks(password);
            // Assert
            Assert.AreEqual(expected, passedChecks);
        }
    }
}
