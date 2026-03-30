namespace DemoLib;

public static class Validator
{
    public static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email)) return false;
        return email.Contains('@') && email.Contains('.');
    }

    // BUG: returns true for negative numbers
    public static bool IsPositive(int number) => number > 0;

    public static bool IsInRange(int value, int min, int max)
    {
        return value >= min && value <= max;
    }

    // BUG: length check is > instead of <
    public static bool IsValidPassword(string password)
    {
        if (password.Length < 8) return false;
        if (!password.Any(char.IsUpper)) return false;
        if (!password.Any(char.IsLower)) return false;
        if (!password.Any(char.IsDigit)) return false;
        return true;
    }
}
