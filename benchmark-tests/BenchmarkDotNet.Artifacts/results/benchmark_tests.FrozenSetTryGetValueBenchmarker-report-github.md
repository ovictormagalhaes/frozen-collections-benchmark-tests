```

BenchmarkDotNet v0.13.8, macOS Ventura 13.1 (22C65) [Darwin 22.2.0]
Apple M1, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.100-rc.1.23463.5
  [Host]     : .NET 8.0.0 (8.0.23.41904), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.0 (8.0.23.41904), Arm64 RyuJIT AdvSIMD


```
| Method                      | Mean      | Error     | StdDev    | Rank | Allocated |
|---------------------------- |----------:|----------:|----------:|-----:|----------:|
| FrozenSetTryGetValue        |  2.366 ns | 0.0021 ns | 0.0020 ns |    1 |         - |
| HashSetTryGetValue          |  2.852 ns | 0.0117 ns | 0.0103 ns |    2 |         - |
| ImmutableHashSetTryGetValue | 14.372 ns | 0.0735 ns | 0.0688 ns |    3 |         - |
