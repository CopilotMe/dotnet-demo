using Xunit;

namespace DemoLib.Tests;

public class ValidatorTests
{
    [Fact]
    public void IsValidEmail_ValidEmail_ReturnsTrue()
    {
        Assert.True(Validator.IsValidEmail("user@example.com"));
    }

    [Fact]
    public void IsValidEmail_InvalidEmail_ReturnsFalse()
    {
        Assert.False(Validator.IsValidEmail("not-an-email"));
    }

    [Fact]
    public void IsPositive_PositiveNumber_ReturnsTrue()
    {
        Assert.True(Validator.IsPositive(5));
    }

    [Fact]
    public void IsPositive_NegativeNumber_ReturnsFalse()
    {
        // Will FAIL — IsPositive returns true for negative numbers
        Assert.False(Validator.IsPositive(-3));
    }

    [Fact]
    public void IsPositive_Zero_ReturnsFalse()
    {
        Assert.False(Validator.IsPositive(0));
    }

    [Fact]
    public void IsInRange_ValueInRange_ReturnsTrue()
    {
        Assert.True(Validator.IsInRange(5, 1, 10));
    }

    [Fact]
    public void IsInRange_ValueOutOfRange_ReturnsFalse()
    {
        Assert.False(Validator.IsInRange(15, 1, 10));
    }

    [Fact]
    public void IsValidPassword_StrongPassword_ReturnsTrue()
    {
        // Will FAIL — IsValidPassword has wrong length check (> instead of <)
        Assert.True(Validator.IsValidPassword("MyPass123"));
    }

    [Fact]
    public void IsValidPassword_ShortPassword_ReturnsFalse()
    {
        Assert.False(Validator.IsValidPassword("Ab1"));
    }

    [Fact]
    public void IsValidPassword_NoUppercase_ReturnsFalse()
    {
        Assert.False(Validator.IsValidPassword("password123"));
    }
}
