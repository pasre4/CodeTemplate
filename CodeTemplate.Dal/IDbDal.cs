using CodeTemplate.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTemplate.Dal
{
    public interface IDbDal
    {
        IDbConnection GetDbConnection(string dbconn);

        List<TabelFieldModel> GetTabelFields(string dbconn, string tabelName);

        List<TableModel> GetAllTables(string dbconn);
    }
}
