namespace DemoLib;

public static class StringUtils
{
    public static string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        return new string(input.Reverse().ToArray());
    }

    // BUG: should count words, but counts characters instead
    public static int WordCount(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return 0;
        return input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static string Truncate(string input, int maxLength)
    {
        if (input.Length <= maxLength) return input;
        return input[..maxLength] + "...";
    }

    public static bool IsPalindrome(string input)
    {
        var clean = input.ToLower().Replace(" ", "");
        var reversed = new string(clean.Reverse().ToArray());
        return clean == reversed;
    }
}
