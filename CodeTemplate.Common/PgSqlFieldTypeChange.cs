using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTemplate.Common
{
    public static class PgSqlFieldTypeChange
    {
        public static string PgSqlToModelType(this string value)
        {
            var type = value?.Trim()?.ToLower() ?? string.Empty;
            var ret = "string";
            switch (type)
            {
                case "bigint": ret = "long"; break;
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                case "text":
                case "bpchar":
                case "ntext": ret = "string"; break;
                case "tinyint": ret = "byte"; break;
                case "int4": ret = "int"; break;
                case "timestamp":
                case "time":
                case "date":
                case "datetime": ret = "DateTime"; break;
                case "decimal":
                case "float8": ret = "double"; break;
                case "bit": ret = "bool"; break;
            }
            
            return ret;
        }

        public static string PgSqlToDefault(this string value)
        {
            var type = value?.Trim()?.ToLower() ?? string.Empty;
            var ret = " = string.Empty;";
            switch (type)
            {
                case "float8": 
                case "decimal":
                case "int4":
                case "bigint": ret = " = 0;"; break;
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                case "text":
                case "bpchar":
                case "ntext": ret = " = string.Empty;"; break;
                case "timestamp":
                case "time":
                case "date":
                case "datetime": ret = " = new DateTime(1900,1,1);"; break;
                case "bit": ret = " = false;"; break;
                case "tinyint": ret = "byte"; break;
            }

            return ret;
        }
    }
}
