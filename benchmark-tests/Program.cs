// See https://aka.ms/new-console-template for more information

using benchmark_tests;
using BenchmarkDotNet.Running;

// var summary = BenchmarkRunner.Run<FrozenDictionaryTryGetValueBenchmarker>();
var summary = BenchmarkRunner.Run<FrozenSetTryGetValueBenchmarker>();
//var summary = BenchmarkRunner.Run<FrozenCountBenchmarker>();
// var summary = BenchmarkRunner.Run<FrozenAppendBenchmarker>();
Console.WriteLine("- - - - - -");
