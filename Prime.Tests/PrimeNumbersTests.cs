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
}