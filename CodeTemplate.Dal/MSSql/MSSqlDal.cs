using CodeTemplate.Entity;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CodeTemplate.Dal
{
    public class MSSqlDal : IDbDal
    {
        public IDbConnection GetDbConnection(string dbconn)
        {
            return MSSqlHelper.GetConnection(dbconn);
        }

        public List<TableModel> GetAllTables(string dbconn)
        {
            using (var conn = MSSqlHelper.GetConnection(dbconn))
            {
                return conn.Query<TableModel>("select name from sys.tables order by name").ToList();
            }
        }

        public List<TabelFieldModel> GetTabelFields(string dbconn, string tabelName)
        {
            var sql = $@"SELECT a.name as Name,
                                b.name as Type,
                                isnull(g.[value], ' ') AS [Desc],
                                (case when COLUMNPROPERTY( a.id,a.name,'IsIdentity')=1 then 1 else 0 end) as IsCreasing, 
                                (case when (SELECT count(*) FROM sysobjects  
                                WHERE (name in (SELECT name FROM sysindexes  
                                WHERE (id = a.id) AND (indid in  
                                (SELECT indid FROM sysindexkeys  
                                WHERE (id = a.id) AND (colid in  
                                (SELECT colid FROM syscolumns WHERE (id = a.id) AND (name = a.name)))))))  
                                AND (xtype = 'PK'))>0 then 1 else 0 end) as IsPrimary,
                                COLUMNPROPERTY(a.id,a.name,'PRECISION') as FieldLength,
                                (case when a.isnullable=1 then 1 else 0 end) as IsNull
                            FROM  syscolumns a 
                            left join systypes b on a.xtype=b.xusertype  
                            inner join sysobjects d on a.id=d.id and d.xtype='U' and d.name<>'dtproperties' 
                            left join syscomments e on a.cdefault=e.id  
                            left join sys.extended_properties g on a.id=g.major_id AND a.colid=g.minor_id
                            left join sys.extended_properties f on d.id=f.class and f.minor_id=0
                            where d.name = '{tabelName}'
                            order by a.id,a.colorder";
            using (var conn = MSSqlHelper.GetConnection(dbconn))
            {
                return conn.Query<TabelFieldModel>(sql).ToList();
            }
        }
    }
}