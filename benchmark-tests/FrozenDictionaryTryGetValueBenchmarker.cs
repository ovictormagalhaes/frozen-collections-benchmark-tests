using System.Collections.Frozen;
using System.Collections.Immutable;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;

namespace benchmark_tests
{
    [MemoryDiagnoser]
    [HideColumns("Error", "StdDev", "Median", "RatioSD")]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class FrozenDictionaryTryGetValueBenchmarker
    {
        private const int Key = 5000;
        private const int OneMilion = 1_000_000;
        private readonly Dictionary<int, int> _dictionary = Enumerable.Range(0, OneMilion).ToDictionary(x => x);
        private readonly FrozenDictionary<int, int> _frozenDictionary = Enumerable.Range(0, OneMilion).ToFrozenDictionary(x => x);
        private readonly ImmutableDictionary<int, int> _immutableDictionary = Enumerable.Range(0, OneMilion).ToImmutableDictionary(x => x);

        [Benchmark]
        public void DictionaryTryGetValue()
        {
            _dictionary.TryGetValue(Key, out _);
        }

        [Benchmark]
        public void FrozenDictionaryTryGetValue()
        {
            _frozenDictionary.TryGetValue(Key, out _);
        }

        [Benchmark]
        public void ImmutableDictionaryTryGetValue()
        {
            _immutableDictionary.TryGetValue(Key, out _);
        }
    }
}