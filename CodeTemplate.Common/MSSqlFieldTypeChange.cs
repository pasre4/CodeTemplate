﻿using System;
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
                case "ntext": ret = "string"; break;
                case "tinyint": ret = "byte"; break;
                case "int": ret = "int"; break;
                case "timestamp":
                case "time":
                case "date":
                case "datetime": ret = "DateTime"; break;
                case "decimal":
                case "float": ret = "double"; break;
                case "bit": ret = "bool"; break;
            }
            
            return ret;
        }

        public static string MSSqlToDefault(this string value)
        {
            var type = value?.Trim()?.ToLower() ?? string.Empty;
            var ret = " = string.Empty;";
            switch (type)
            {
                case "float": 
                case "decimal":
                case "int":
                case "bigint": ret = " = 0;"; break;
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                case "text":
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
