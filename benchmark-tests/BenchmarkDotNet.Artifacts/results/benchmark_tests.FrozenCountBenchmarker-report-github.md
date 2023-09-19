```

BenchmarkDotNet v0.13.8, macOS Ventura 13.1 (22C65) [Darwin 22.2.0]
Apple M1, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.100-rc.1.23463.5
  [Host]     : .NET 8.0.0 (8.0.23.41904), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.0 (8.0.23.41904), Arm64 RyuJIT AdvSIMD


```
| Method                   | Mean     | Error     | StdDev    | Rank | Allocated |
|------------------------- |---------:|----------:|----------:|-----:|----------:|
| DictionaryCount          | 1.899 ns | 0.0289 ns | 0.0256 ns |    1 |         - |
| FrozenDictionaryCount    | 1.941 ns | 0.0161 ns | 0.0150 ns |    2 |         - |
| ImmutableDictionaryCount | 3.446 ns | 0.0438 ns | 0.0365 ns |    3 |         - |
