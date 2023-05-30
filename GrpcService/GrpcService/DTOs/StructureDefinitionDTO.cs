using System;
using System.Collections.Generic;
using System.Text;

namespace GrpcClient.DTOs
{
    public class StructureDefinitionDTO
    {
        public string? Name { get; set; }
        public int? Type { get; set; }
        public bool IsList { get; set; }
        public bool IsNullable { get; set; }
        public string? Format { get; set; }
        public int? Aggregation { get; set; }
        public string? Labels { get; set; }
    }
}
