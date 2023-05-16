``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2846/21H2/November2021Update)
Intel Xeon CPU E5-1620 0 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.202
  [Host]     : .NET Core 3.1.22 (CoreCLR 4.700.21.56803, CoreFX 4.700.21.57101), X64 RyuJIT AVX [AttachedDebugger]
  DefaultJob : .NET Core 3.1.22 (CoreCLR 4.700.21.56803, CoreFX 4.700.21.57101), X64 RyuJIT AVX


```
|                        Method |           Mean |        Error |        StdDev |         Median |
|------------------------------ |---------------:|-------------:|--------------:|---------------:|
|     ProtoBufSerialization_SOM |       545.9 μs |     12.21 μs |      35.80 μs |       539.0 μs |
|             InitOMFromDTO_SOM |     4,144.8 μs |     81.85 μs |     167.21 μs |     4,172.5 μs |
| TransmissionTime_ProtoBuf_SOM |    15,440.2 μs |    424.48 μs |   1,238.24 μs |    15,048.1 μs |
|   ProtoBufDeserialization_SOM |       738.8 μs |     10.03 μs |       8.89 μs |       739.3 μs |
|     ProtoBufSerialization_BOM |    36,552.7 μs |    729.77 μs |   1,601.87 μs |    36,276.6 μs |
|             InitOMFromDTO_BOM |   271,204.1 μs |  6,207.24 μs |  17,200.23 μs |   268,320.8 μs |
| TransmissionTime_ProtoBuf_BOM |   378,840.6 μs |  7,431.20 μs |  13,208.95 μs |   378,697.7 μs |
|   ProtoBufDeserialization_BOM |    35,468.3 μs |    692.20 μs |   1,617.99 μs |    35,625.3 μs |
|     ProtoBufSerialization_SFM |     7,718.1 μs |    114.68 μs |     164.47 μs |     7,664.5 μs |
|             InitOMFromDTO_SFM |    28,805.3 μs |    555.00 μs |   1,146.16 μs |    28,263.5 μs |
| TransmissionTime_ProtoBuf_SFM |    20,697.3 μs |    924.46 μs |   2,696.68 μs |    20,698.0 μs |
|   ProtoBufDeserialization_SFM |     6,554.0 μs |    121.05 μs |     113.23 μs |     6,522.0 μs |
|     ProtoBufSerialization_BFM |   716,587.3 μs | 11,896.42 μs |  12,216.74 μs |   713,333.7 μs |
|             InitOMFromDTO_BFM | 2,827,397.5 μs | 56,301.17 μs | 131,602.17 μs | 2,780,752.9 μs |
| TransmissionTime_ProtoBuf_BFM |   579,777.9 μs | 11,560.74 μs |  26,562.73 μs |   570,413.8 μs |
|   ProtoBufDeserialization_BFM |   959,768.9 μs |  9,646.87 μs |  11,109.35 μs |   958,039.9 μs |
