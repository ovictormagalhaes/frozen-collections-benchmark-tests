using System.Collections.Frozen;
using System.Collections.Immutable;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;

namespace benchmark_tests
{
    [MemoryDiagnoser(displayGenColumns: false)]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class FrozenSetTryGetValueBenchmarker
    {
        private const int Key = 5000;
        private const int OneMilion = 1_000_000;
        private readonly HashSet<int> _hashSet = Enumerable.Range(0, OneMilion).ToHashSet();
        private readonly FrozenSet<int> _frozenSet = Enumerable.Range(0, OneMilion).ToFrozenSet();
        private readonly ImmutableHashSet<int> _immutableHashSet = Enumerable.Range(0, OneMilion).ToImmutableHashSet();

        [Benchmark]
        public void HashSetTryGetValue()
        {
            _hashSet.TryGetValue(Key, out _);
        }

        [Benchmark]
        public void FrozenSetTryGetValue()
        {
            _frozenSet.TryGetValue(Key, out _);
        }

        [Benchmark]
        public void ImmutableHashSetTryGetValue()
        {
            _immutableHashSet.TryGetValue(Key, out _);
        }
    }
}