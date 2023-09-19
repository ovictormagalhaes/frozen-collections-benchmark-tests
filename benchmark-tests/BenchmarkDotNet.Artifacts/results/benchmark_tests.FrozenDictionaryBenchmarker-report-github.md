```

BenchmarkDotNet v0.13.8, macOS Ventura 13.1 (22C65) [Darwin 22.2.0]
Apple M1, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.100-rc.1.23463.5
  [Host]     : .NET 8.0.0 (8.0.23.41904), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.0 (8.0.23.41904), Arm64 RyuJIT AdvSIMD


```
| Method                         | Mean      | Error     | StdDev    | Rank | Allocated |
|------------------------------- |----------:|----------:|----------:|-----:|----------:|
| FrozenDictionaryTryGetValue    |  1.330 ns | 0.0038 ns | 0.0034 ns |    1 |         - |
| DictionaryTryGetValue          |  2.569 ns | 0.0150 ns | 0.0141 ns |    2 |         - |
| ImmutableDictionaryTryGetValue | 14.998 ns | 0.0640 ns | 0.0534 ns |    3 |         - |
