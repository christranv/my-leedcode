using BenchmarkDotNet.Attributes;
using LeedCode.Leedcode;

namespace LeedCode.Benchmark;

[MemoryDiagnoser]
public class TwoSumBenchMark
{
    private int[] _nums = Array.Empty<int>();
    private int _target;

    [GlobalSetup]
    public void Setup()
    {
        _nums = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        _target = 16;
    }

    [Benchmark(Baseline = true)]
    public int[] Execute() => new TwoSum().Execute(_nums, _target);
}