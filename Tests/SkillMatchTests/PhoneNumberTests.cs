namespace SkillMatchTests;

using Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class PhoneNumberTests
{
    [TestMethod]
    public void Create_ValidPhoneNumber_ShouldSucceed()
    {
        // Arrange
        var validPhoneNumber = "+1 (123) 456-7890";

        // Act
        var phoneNumber = PhoneNumber.Create(validPhoneNumber);

        // Assert
        Assert.AreEqual(validPhoneNumber, phoneNumber.ToString());
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Create_InvalidPhoneNumber_ShouldThrowException()
    {
        // Arrange
        var invalidPhoneNumber = "abc";

        // Act
        PhoneNumber.Create(invalidPhoneNumber);
    }

    [TestMethod]
    public void Equals_SamePhoneNumber_ShouldReturnTrue()
    {
        // Arrange
        var phoneNumber1 = PhoneNumber.Create("+1 (123) 456-7890");
        var phoneNumber2 = PhoneNumber.Create("+1 (123) 456-7890");

        // Act & Assert
        Assert.IsTrue(phoneNumber1.Equals(phoneNumber2));
        Assert.IsTrue(phoneNumber1 == phoneNumber2);
    }

    [TestMethod]
    public void Equals_DifferentPhoneNumber_ShouldReturnFalse()
    {
        // Arrange
        var phoneNumber1 = PhoneNumber.Create("+1 (123) 456-7890");
        var phoneNumber2 = PhoneNumber.Create("+1 (987) 654-3210");

        // Act & Assert
        Assert.IsFalse(phoneNumber1.Equals(phoneNumber2));
        Assert.IsFalse(phoneNumber1 == phoneNumber2);
    }

    [TestMethod]
    public void GetHashCode_SamePhoneNumber_ShouldReturnSameHashCode()
    {
        // Arrange
        var phoneNumber1 = PhoneNumber.Create("+1 (123) 456-7890");
        var phoneNumber2 = PhoneNumber.Create("+1 (123) 456-7890");

        // Act & Assert
        Assert.AreEqual(phoneNumber1.GetHashCode(), phoneNumber2.GetHashCode());
    }
}
