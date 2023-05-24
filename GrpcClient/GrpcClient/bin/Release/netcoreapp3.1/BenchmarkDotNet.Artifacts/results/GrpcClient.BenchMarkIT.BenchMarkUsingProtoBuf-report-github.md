``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19044.2965/21H2/November2021Update)
Intel Xeon CPU E5-1620 0 3.60GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]     : .NET Core 3.1.22 (CoreCLR 4.700.21.56803, CoreFX 4.700.21.57101), X64 RyuJIT AVX [AttachedDebugger]
  DefaultJob : .NET Core 3.1.22 (CoreCLR 4.700.21.56803, CoreFX 4.700.21.57101), X64 RyuJIT AVX


```
|                        Method |           Mean |        Error |        StdDev |         Median |
|------------------------------ |---------------:|-------------:|--------------:|---------------:|
|     ProtoBufSerialization_SOM |       649.7 μs |     14.89 μs |      42.48 μs |       632.5 μs |
|             InitOMFromDTO_SOM |     5,172.5 μs |     94.31 μs |     183.93 μs |     5,128.8 μs |
| TransmissionTime_ProtoBuf_SOM |    15,804.1 μs |    315.49 μs |     808.71 μs |    15,543.2 μs |
|   ProtoBufDeserialization_SOM |       842.9 μs |     16.21 μs |      19.90 μs |       836.7 μs |
|     ProtoBufSerialization_BOM |    41,563.3 μs |    827.43 μs |   1,336.15 μs |    41,106.3 μs |
|             InitOMFromDTO_BOM |   316,705.4 μs |  6,245.58 μs |   7,898.66 μs |   316,859.0 μs |
| TransmissionTime_ProtoBuf_BOM |   390,736.3 μs |  7,449.31 μs |  18,132.64 μs |   383,234.3 μs |
|   ProtoBufDeserialization_BOM |    36,990.6 μs |    737.19 μs |     958.56 μs |    36,784.1 μs |
|     ProtoBufSerialization_SFM |     4,244.8 μs |     51.32 μs |      40.07 μs |     4,257.9 μs |
|             InitOMFromDTO_SFM |    33,651.9 μs |    465.38 μs |     388.61 μs |    33,490.9 μs |
| TransmissionTime_ProtoBuf_SFM |    25,344.9 μs |    499.89 μs |   1,263.29 μs |    25,075.5 μs |
|   ProtoBufDeserialization_SFM |     8,068.2 μs |    160.01 μs |     330.45 μs |     7,934.1 μs |
|     ProtoBufSerialization_BFM |   712,145.0 μs |  8,572.47 μs |   9,872.07 μs |   710,115.4 μs |
|             InitOMFromDTO_BFM | 4,257,556.9 μs | 84,156.41 μs | 177,514.43 μs | 4,214,327.9 μs |
| TransmissionTime_ProtoBuf_BFM | 2,742,252.0 μs | 81,447.09 μs | 238,870.23 μs | 2,747,041.9 μs |
|   ProtoBufDeserialization_BFM | 2,093,657.8 μs | 37,080.26 μs |  30,963.69 μs | 2,081,158.1 μs |
