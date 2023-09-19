```

BenchmarkDotNet v0.13.8, macOS Ventura 13.1 (22C65) [Darwin 22.2.0]
Apple M1, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.100-rc.1.23463.5
  [Host]     : .NET 8.0.0 (8.0.23.41904), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.0 (8.0.23.41904), Arm64 RyuJIT AdvSIMD


```
| Method                   | Mean      | Error     | StdDev    | Rank | Allocated |
|------------------------- |----------:|----------:|----------:|-----:|----------:|
| DictionaryWhere          |  9.811 ns | 0.0367 ns | 0.0307 ns |    1 |      56 B |
| FrozenDictionaryWhere    | 10.277 ns | 0.0444 ns | 0.0394 ns |    2 |      56 B |
| ImmutableDictionaryWhere | 10.709 ns | 0.0807 ns | 0.0715 ns |    3 |      56 B |
