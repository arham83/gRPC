``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2965/21H2/November2021Update)
Intel Xeon CPU E5-1620 0 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]     : .NET Core 3.1.22 (CoreCLR 4.700.21.56803, CoreFX 4.700.21.57101), X64 RyuJIT AVX [AttachedDebugger]
  DefaultJob : .NET Core 3.1.22 (CoreCLR 4.700.21.56803, CoreFX 4.700.21.57101), X64 RyuJIT AVX


```
|                        Method |        Mean |     Error |     StdDev |
|------------------------------ |------------:|----------:|-----------:|
| TransmissionTime_ProtoBuf_SOM |    16.92 ms |  0.435 ms |   1.228 ms |
| TransmissionTime_ProtoBuf_BOM |   464.07 ms | 15.644 ms |  45.636 ms |
| TransmissionTime_ProtoBuf_SFM |    29.30 ms |  1.209 ms |   3.371 ms |
| TransmissionTime_ProtoBuf_BFM | 2,843.21 ms | 78.922 ms | 231.465 ms |
