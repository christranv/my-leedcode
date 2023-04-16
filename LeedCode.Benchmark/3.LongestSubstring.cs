using BenchmarkDotNet.Attributes;

namespace LeedCode.Benchmark;

[MemoryDiagnoser]
public class LongestSubstringBenchMark
{
    [GlobalSetup]
    public void Setup()
    {
    }

    // [Benchmark(Baseline = true)]
    // public int[] Execute() => Execute(_nums, _target);
    //
    // private int[] Execute(int[] nums, int target)
    // {
    // }
}