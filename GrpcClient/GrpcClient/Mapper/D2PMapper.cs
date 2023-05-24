                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     using gRPC.Client.SerializerDeserializer;
using GrpcClient.DTOs;
using GrpcService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrpcClient.Mapper
{
    // DTO to Proto Mapper
    public class D2PMapper
    {
        public static FullMessage InitFMFromDTO(string path)
        {
            var DTO_FM = JsonHandler.DeserializeJson<FullMessageDTO>(path);
            FullMessage FM = new FullMessage();
            // Mapping Header 
            foreach (var item in DTO_FM.Header)
            {
                FM.Header.Add(new StructureDefinition
                {
                    Name = item.Name,
                    Type = item.Type,
                    IsList = item.IsList,
                    IsNullable = item.IsNullable,
                    Format = item.Format,
                    Aggregation = item.Aggregation,
                    Labels = item.Labels
                });
            }
            // Mapping Rows
            foreach (var row in DTO_FM.Rows)
            {
                var newRow = new Row3();
                //var nonNullValues = row.Where(v => v != null);
                // Replacing null Values with the Empty String 
                 List<object> modifiedList = row.Select(item => item ?? string.Empty).ToList();
                foreach (var value in modifiedList)
                {
                    Value3 newValue = new Value3();
                    //Console.WriteLine("Value " + value.GetType() + " " + value);
                    // Check the type of the value object and assign it to the appropriate field in Value3
                    if (value is bool boolValue)
                    {
                        newValue.A = boolValue;
                    }
                    else if (value is int intValue)
                    {
                        newValue.B = intValue;
                    }
                    else if (value is long longValue)
                    {
                        newValue.C = longValue;
                    }
                    else if (value is string stringValue)
                    {
                        newValue.D = stringValue;
                    }
                    else if (value is double doubleValue)
                    {
                        newValue.E = doubleValue;
                    }
                    else
                    {
                        // Unsupported typ
                        continue; // Skip this value and move to the next iteration
                    }

                    newRow.Values.Add(newValue);
                }
                FM.Rows.Add(newRow);
            }
            return FM;
        }

        public static OptimizedMessage InitOMFromDTO(string path)
        {
            var OMDTO = JsonHandler.DeserializeJson<OptimizedMessageDTO>(path);
            OptimizedMessage OM = new OptimizedMessage();
            foreach (var item in OMDTO.Header)
            {
                OM.Header.Add(new StructureDefinition
                {
                    Name = item.Name,
                    Type = item.Type,
                    IsList = item.IsList,
                    IsNullable = item.IsNullable,
                    Format = item.Format,
                    Aggregation = item.Aggregation,
                    Labels = item.Labels
                });
            }
            OM.Rows = OMDTO.RowData;
            return OM;
        }
    }
}
                                                                                                                                     