using CodeTemplate.Dal;
using CodeTemplate.Entity;
using System;
using System.Collections.Generic;

namespace CodeTemplate.Bll
{
    public class DbBll
    {
        private readonly IDbDal msSqlDal = new MSSqlDal();
        private readonly IDbDal pgSqlDal = new PGSqlDal();

        public List<TableModel> GetAllTables(DbCombobox select)
        {
            switch (select.Type)
            {
                case "MSSQL": return msSqlDal.GetAllTables(select.Read);
                case "POSTGRESQL": return pgSqlDal.GetAllTables(select.Read);
            }
            return null;
        }

        public List<TabelFieldModel> GetTabelFields(DbCombobox select, string tabelName)
        {
            switch (select.Type)
            {
                case "MSSQL": return msSqlDal.GetTabelFields(select.Read, tabelName);
                case "POSTGRESQL": return pgSqlDal.GetTabelFields(select.Read, tabelName);
            }
            return null;
        }
    }
}