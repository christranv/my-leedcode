using BenchmarkDotNet.Attributes;
using LeedCode.Leedcode;

namespace LeedCode.Benchmark;

[MemoryDiagnoser]
public class ThreeSumBenchMark
{
    private ListNode _l1;
    private ListNode _l2;

    [GlobalSetup]
    public void Setup()
    {
        _l1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
        _l2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));
    }

    [Benchmark(Baseline = true)]
    public ListNode Execute() => new AddTwoNumbers().Execute(_l1, _l2);
}