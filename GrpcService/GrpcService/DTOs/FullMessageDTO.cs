using System;
using System.Collections.Generic;
using System.Text;

namespace GrpcClient.DTOs
{
    public class FullMessageDTO
    {
        public List<StructureDefinitionDTO> Header { get; set; }
        public List<List<object>> Rows { get; set; }
    }
}
