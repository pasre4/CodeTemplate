using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeTemplate.Common
{
    public class FieldTypeChange
    {
        public string Type { get; }

        public FieldTypeChange(string type)
        {
            this.Type = type;
        }

        public string ToModelType(string value)
        {
            switch (Type)
            {
                case "MSSQL": return value.MSSqlToModelType();
                case "POSTGRESQL": return value.PgSqlToModelType();
                default: return "string";
            }
        }

        public string ToModelDefault(string value)
        {
            switch (Type)
            {
                case "MSSQL": return value.MSSqlToDefault();
                case "POSTGRESQL": return value.PgSqlToDefault();
                default: return " = string.Empty;";
            }
        }

        public object ToModelEntityName(string name)
        {
            switch (Type)
            {
                case "MSSQL": return name;
                case "POSTGRESQL": return name.toCamelCase();
                default: return name;
            }
        }

        public object ToColumnName(string name)
        {
            switch (Type)
            {
                case "MSSQL": return "";
                case "POSTGRESQL": return $"[Column(\"{name}\")]";
                default: return "";
            }
        }
    }
}
