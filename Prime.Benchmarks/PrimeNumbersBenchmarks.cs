using BenchmarkDotNet.Attributes;

namespace Prime.Benchmarks;

[InProcess] // Use the inProcess runner for faster execution
[MemoryDiagnoser] // Track the memory
public class PrimeNumbersBenchmarks
{
    [Benchmark]
    public void IsPrimeNumber10_000()
    {
        var result = PrimeNumbers.Get(1, 10_000).ToList();
    }

    [Benchmark]
    public void IsPrimeNumber100_000()
    {
        var result = PrimeNumbers.Get(1, 100_000).ToList();
    }

}