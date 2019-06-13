using CodeTemplate.Dal;
using CodeTemplate.Entity;
using System;
using System.Collections.Generic;

namespace CodeTemplate.Bll
{
    public class DbBll
    {
        private readonly Lazy<DbDal> dbDal = new Lazy<DbDal>();

        public List<TableModel> GetAllTables(DbCombobox select)
        {
            return dbDal.Value.GetAllTables(select);
        }

        public List<TabelFieldModel> GetTabelFields(DbCombobox select, string tabelName)
        {
            return dbDal.Value.GetTabelFields(select, tabelName);
        }
    }
}