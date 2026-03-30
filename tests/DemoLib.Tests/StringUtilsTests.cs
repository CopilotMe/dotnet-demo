using Xunit;

namespace DemoLib.Tests;

public class StringUtilsTests
{
    [Fact]
    public void Reverse_ReturnsReversedString()
    {
        Assert.Equal("olleh", StringUtils.Reverse("hello"));
    }

    [Fact]
    public void Reverse_EmptyString_ReturnsEmpty()
    {
        Assert.Equal("", StringUtils.Reverse(""));
    }

    [Fact]
    public void WordCount_ReturnsCorrectCount()
    {
        // Will FAIL — WordCount returns character count, not word count
        Assert.Equal(3, StringUtils.WordCount("hello world today"));
    }

    [Fact]
    public void WordCount_EmptyString_ReturnsZero()
    {
        Assert.Equal(0, StringUtils.WordCount(""));
    }

    [Fact]
    public void Truncate_ShortString_ReturnsUnchanged()
    {
        Assert.Equal("hello", StringUtils.Truncate("hello", 10));
    }

    [Fact]
    public void Truncate_LongString_TruncatesWithEllipsis()
    {
        Assert.Equal("hello w...", StringUtils.Truncate("hello world", 7));
    }

    [Fact]
    public void IsPalindrome_ReturnsTrueForPalindrome()
    {
        Assert.True(StringUtils.IsPalindrome("racecar"));
    }

    [Fact]
    public void IsPalindrome_ReturnsFalseForNonPalindrome()
    {
        Assert.False(StringUtils.IsPalindrome("hello"));
    }
}
