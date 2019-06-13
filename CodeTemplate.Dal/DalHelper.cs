using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CodeTemplate.Dal
{
    internal static class DalHelper
    {
        internal static IDbConnection GetConnection(string dbName)
        {
            //SqlMapperExtensions.GetDatabaseType = DataSource.GetDatabaseType;
            //return DataSource.GetConnection(library, isReadDb);

            return new SqlConnection(ConfigurationManager.ConnectionStrings[dbName].ConnectionString);
        }

        internal static string GetQuerySqlString<T>()
        {
            var propList = GetPropertieList<T>();
            var strSql = string.Empty;
            if (propList.IsAny())
            {
                strSql = propList.Aggregate("Select ", (current, info) => current + ($"`{info.Name}`,")).TrimEnd(',');
                strSql += " From " + typeof(T).Name + " Where 1=1";
            }
            return strSql;
        }

        private static PropertyInfo[] GetPropertieList<T>()
        {
            return typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public);
        }

        internal static IEnumerable<T> QueryModel<T>(this IDbConnection conn, object param, IDbTransaction tran = null, string orderBy = null) where T : class
        {
            return QueryModelAsync<T>(conn, param, tran, orderBy).Result;
        }

        internal async static Task<IEnumerable<T>> QueryModelAsync<T>(this IDbConnection conn, object param, IDbTransaction tran = null, string orderBy = null) where T : class
        {
            var sql = GetQuerySqlString<T>();
            if (param != null)
            {
                var propList = param.GetType().GetProperties();
                if (propList.IsAny())
                {
                    sql = propList.Aggregate(sql, (current, info) => current + (string.Format(" and {0} = @{0}", info.Name)));
                }
            }
            if (!string.IsNullOrWhiteSpace(orderBy))
            {
                sql += " order by " + orderBy;
            }
            return await conn.QueryAsync<T>(sql, param, tran);
        }

        internal static IEnumerable<T> QueryWithPage<T>(this IDbConnection conn, string sql, object param, long index, long size, IDbTransaction tran = null, string orderBy = null) where T : class
        {
            return QueryWithPageAsync<T>(conn, sql, param, index, size, tran, orderBy).Result;
        }

        internal async static Task<IEnumerable<T>> QueryWithPageAsync<T>(this IDbConnection conn, string sql, object param, long index, long size, IDbTransaction tran = null, string orderBy = null) where T : class
        {
            if (!string.IsNullOrWhiteSpace(orderBy))
            {
                sql += " order by " + orderBy;
            }
            sql += $" limit {(index - 1) * size},{size}";
            return await conn.QueryAsync<T>(sql, param, tran);
        }

        internal static IEnumerable<T> QueryModelWithPage<T>(this IDbConnection conn, object param, long index, long size, IDbTransaction tran = null, string orderBy = null) where T : class
        {
            return QueryModelWithPageAsync<T>(conn, param, index, size, tran, orderBy).Result;
        }

        internal async static Task<IEnumerable<T>> QueryModelWithPageAsync<T>(this IDbConnection conn, object param, long index, long size, IDbTransaction tran = null, string orderBy = null) where T : class
        {
            var sql = GetQuerySqlString<T>();
            var propList = param.GetType().GetProperties();
            if (propList.IsAny())
            {
                sql = propList.Aggregate(sql, (current, info) => current + (string.Format(" and {0} = @{0}", info.Name)));
            }
            return await conn.QueryWithPageAsync<T>(sql, param, index, size, tran, orderBy);
        }
    }
}