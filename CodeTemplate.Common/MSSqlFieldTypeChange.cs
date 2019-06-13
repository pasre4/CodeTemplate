using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTemplate.Common
{
    public static class MSSqlFieldTypeChange
    {
        public static string MSSqlToModelType(this string value)
        {
            var type = value.Trim().ToLower();
            var ret = "string";
            switch (type)
            {
                case "bigint": ret = "long"; break;
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                case "text":
                case "ntext": ret = "string"; break;
                case "int": ret = "int"; break;
                case "timestamp":
                case "time":
                case "datetime": ret = "DateTime"; break;
                case "decimal":
                case "float": ret = "double"; break;
            }
            
            return ret;
        }
    }
}
