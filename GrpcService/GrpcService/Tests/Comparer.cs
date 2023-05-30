using GrpcClient.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Tests
{
    public class Comparer
    {
        public bool CompareFM(FullMessageDTO x, FullMessage y)
        {
            if (x is null || y is null)
                return false;

            if (x.Header.Count != y.Header.Count)
                return false;

            if (x.Rows.Count != y.Rows.Count)
                return false;

            for (int i = 0; i < x.Header.Count; i++)
            {
                if (x.Header[i].Name != y.Header[i].Name)
                    return false;
                if (x.Header[i].Type != y.Header[i].Type)
                    return false;
                if (x.Header[i].IsList != y.Header[i].IsList)
                    return false;
                if (x.Header[i].IsNullable != y.Header[i].IsNullable)
                    return false;
                if (x.Header[i].Format != y.Header[i].Format)
                    return false;
                if (x.Header[i].Aggregation != y.Header[i].Aggregation)
                    return false;
                if (x.Header[i].Labels != y.Header[i].Labels)
                    return false;
            }

            for (int i = 0; i < x.Rows.Count; i++)
            {
                for (int j = 0; j < x.Rows[i].Count; i++)
                {
                    Console.WriteLine(y.Rows[i]);
                    Console.WriteLine(y.Rows[i].Values[0].D);
                    if (x.Rows[i][j] != y.Rows[i].Values[j])
                    {
                        Console.WriteLine(x.Rows[i][j] + "" + y.Rows[i].Values[j]);
                        return false;
                    }
                }
            }

            return true;
        }

        public bool CompareOM(OptimizedMessageDTO x, OptimizedMessage y)
        {
            if (x is null || y is null)
                return false;

            if (x.Header.Count != y.Header.Count || x.RowData != y.Rows)
                return false;

            for (int i = 0; i < x.Header.Count; i++)
            {
                if (x.Header[i].Name != y.Header[i].Name)
                    return false;
                if (x.Header[i].Type != y.Header[i].Type)
                    return false;
                if (x.Header[i].IsList != y.Header[i].IsList)
                    return false;
                if (x.Header[i].IsNullable != y.Header[i].IsNullable)
                    return false;
                if (x.Header[i].Format != y.Header[i].Format)
                    return false;
                if (x.Header[i].Aggregation != y.Header[i].Aggregation)
                    return false;
                if (x.Header[i].Labels != y.Header[i].Labels)
                    return false;
            }

            return true;
        }
    }

}

