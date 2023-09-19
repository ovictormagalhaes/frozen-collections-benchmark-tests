```

BenchmarkDotNet v0.13.8, macOS Ventura 13.1 (22C65) [Darwin 22.2.0]
Apple M1, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.100-rc.1.23463.5
  [Host]     : .NET 8.0.0 (8.0.23.41904), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 8.0.0 (8.0.23.41904), Arm64 RyuJIT AdvSIMD


```
| Method                    | Mean     | Error     | StdDev    | Rank | Allocated |
|-------------------------- |---------:|----------:|----------:|-----:|----------:|
| ImmutableDictionaryAppend | 6.248 ns | 0.0570 ns | 0.0506 ns |    1 |      64 B |
| DictionaryAppend          | 7.169 ns | 0.0599 ns | 0.0500 ns |    2 |      64 B |
| FrozenDictionaryAppend    | 7.906 ns | 0.0762 ns | 0.0676 ns |    3 |      64 B |
