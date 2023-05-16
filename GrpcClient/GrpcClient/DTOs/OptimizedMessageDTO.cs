using System;
using System.Collections.Generic;
using System.Text;

namespace GrpcClient.DTOs
{
    class OptimizedMessageDTO
    {
        public List<StructureDefinitionDTO> Header { get; set; }
        public string RowData { get; set; }
    }
}
