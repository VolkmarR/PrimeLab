using Xunit;
using FluentAssertions;
using Prime;

namespace Prime.Tests;

public class PrimeNumbersTests
{
    [Fact]
    public void NegativeNumberTest()
    {
        Action act = () => PrimeNumbers.IsPrimeNumber(-1);
        act.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void Number1ShoudNotBeAPrimeNumberTest()
    {
        PrimeNumbers.IsPrimeNumber(1).Should().BeFalse();
    }

    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    [InlineData(11)]
    [InlineData(13)]
    [InlineData(17)]
    [InlineData(19)]
    [InlineData(23)]
    [InlineData(29)]
    public void NumberShoudBeAPrimeNumberTest(int number)
    {
        PrimeNumbers.IsPrimeNumber(number).Should().BeTrue();
    }


    [Theory]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(9)]
    [InlineData(10)]
    public void NumberShoudNotBeAPrimeNumberTest(int number)
    {
        PrimeNumbers.IsPrimeNumber(number).Should().BeFalse();
    }

}