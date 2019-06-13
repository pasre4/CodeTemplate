using CodeTemplate.Common;
using CodeTemplate.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTemplate.Bll
{
    public class TemplateBll
    {
        public string GenerateEntity(string modelName, IEnumerable<TabelFieldModel> fields)
        {
            var ret = string.Empty;
            var field = new List<string>();
            fields.ToList().ForEach(x =>
            {
                field.Add(string.Format(@"
    /// <summary>
    /// {0}
    /// </summary>
    public {1} {2} {3}
",x.Desc,x.Type.MSSqlToModelType(), x.Name, "{ get; set; }"));
            });

            ret += $@"public class {modelName}Entity : BaseEntity
";
            ret += "{";
            ret += string.Join("", field);
            ret += "}";

            return ret;
        }

        public string GenerateMap(string tableName,string modelName, IEnumerable<TabelFieldModel> fields)
        {
            var template = @"public class ~ENTITYNAME~Map : EntityTypeConfiguration<~ENTITYNAME~Entity>
{
    public ~ENTITYNAME~Map()
    {
        this.ToTable(~TABLENAME~);
        this.HasKey(t => t.~Key~);
    }
}";
            var keyField = fields.First(x => x.IsPrimary);
            var ret = string.Empty;
            ret = template.Replace("~ENTITYNAME~", modelName);
            ret = ret.Replace("~TABLENAME~", "\"" + tableName + "\"");
            ret = ret.Replace("~Key~", keyField == null ? "ID" : keyField.Name);

            return ret;
        }

        public string GenerateRepository(string modelName)
        {
            var template = @"public class ~ENTITYNAME~Repository : RepositoryBase<~ENTITYNAME~Entity>, I~ENTITYNAME~Repository
{
    
}";
            return template.Replace("~ENTITYNAME~", modelName);
        }
    }
}
