using CodeTemplate.Entity;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTemplate.Dal
{
    public class PGSqlDal : IDbDal
    {
        public IDbConnection GetDbConnection(string dbconn)
        {
            var connStr = ConfigurationManager.ConnectionStrings[dbconn].ToString();
            return new NpgsqlConnection(connStr);
        }

        public List<TableModel> GetAllTables(string dbconn)
        {
            using (var conn = this.GetDbConnection(dbconn))
            {
                return conn.Query<TableModel>("select tablename as name from pg_tables where schemaname = 'public'").ToList();
            }
        }

        public List<TabelFieldModel> GetTabelFields(string dbconn, string tabelName)
        {
            using (var conn = this.GetDbConnection(dbconn))
            {
                var sql = $@"SELECT DISTINCT
                                   A.ordinal_position,
                                   A.column_name as Name,
                                   CASE A.is_nullable WHEN 'NO' THEN 0 ELSE 1 END AS IsNull,
	                                 t.typname AS Type,
                                   A.data_type,
                                   coalesce(A.character_maximum_length, A.numeric_precision, -1) as FieldLength,
                                   A.numeric_scale,
                                        CASE WHEN length(B.attname) > 0 THEN 1 ELSE 0 END AS IsPrimary,
	                                 des.description as Desc
                                FROM
                                   information_schema.columns A
                                LEFT JOIN (
                                    SELECT
                                        pg_attribute.attname
                                    FROM
                                        pg_index,
                                        pg_class,
                                        pg_attribute
                                    WHERE
                                        pg_class.oid = '{tabelName}' :: regclass
                                    AND pg_index.indrelid = pg_class.oid
                                    AND pg_attribute.attrelid = pg_class.oid
                                    AND pg_attribute.attnum = ANY (pg_index.indkey)
                                ) B ON A.column_name = b.attname
                                INNER JOIN pg_class c on c.relname = a.table_name
                                INNER JOIN pg_namespace n on n.oid = c.relnamespace and n.nspname = 'public'
                                LEFT JOIN pg_attribute att on A.column_name = att.attname and att.attrelid = c.oid
                                LEFT JOIN pg_description des ON att.attrelid = des.objoid AND att.attnum = des.objsubid and att.attnum > 0
                                LEFT JOIN pg_type t on att.atttypid = t.oid
                                WHERE
                                   A.table_schema = 'public'
                                AND A.table_name = '{tabelName}'
                                ORDER BY
                                   ordinal_position ASC;";
                return conn.Query<TabelFieldModel>(sql).ToList();
            }
        }
    }
}
