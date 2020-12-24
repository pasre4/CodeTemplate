using CodeTemplate.Common;
using CodeTemplate.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTemplate.Bll
{
    public class TemplateBll
    {
        public string GenerateEntity(string modelName, IEnumerable<TabelFieldModel> fields, bool isDefault, string dataBaseType)
        {
            var fieldMethod = new FieldTypeChange(dataBaseType);
            var ret = string.Empty;
            var field = new List<string>();
            fields.ToList().ForEach(x =>
            {
                field.Add(string.Format(@"
    /// <summary>
    /// {0}
    /// </summary>
    {5}
    public {1} {2} {3}{4}
", x.Desc, fieldMethod.ToModelType(x.Type), fieldMethod.ToModelEntityName(x.Name), "{ get; set; }", isDefault ? fieldMethod.ToModelDefault(x.Type) : "", fieldMethod.ToColumnName(x.Name)));
            });

            ret += $"[Table(\"{modelName}\")]";
            ret += $@"
public class {modelName.toCamelCase()}Entity : BaseEntity
";
            ret += "{";
            ret += string.Join("", field);
            ret += "}";

            return ret;
        }

        public string GenerateMap(string tableName, string modelName, IEnumerable<TabelFieldModel> fields)
        {
            var template = @"public class ~ENTITYNAME~Map : EntityTypeConfiguration<~ENTITYNAME~Entity>
{
    public ~ENTITYNAME~Map()
    {
        this.ToTable(~TABLENAME~);
        this.HasKey(t => t.~Key~);
    }
}";
            var keyField = fields.FirstOrDefault(x => x.IsPrimary);
            var ret = string.Empty;
            ret = template.Replace("~ENTITYNAME~", modelName);
            ret = ret.Replace("~TABLENAME~", "\"" + tableName + "\"");
            ret = ret.Replace("~Key~", keyField == null ? "" : keyField.Name);

            return ret;
        }

        public string GenerateRepository(string modelName)
        {
            var template = @"public class ~ENTITYNAME~Repository : RepositoryBase<~ENTITYNAME~Entity>, I~ENTITYNAME~Repository
{
    
}";
            return template.Replace("~ENTITYNAME~", modelName);
        }

        public void ExportEntity(string tableName, string path, string value)
        {
            var filePath = Path.Combine(path, tableName.toCamelCase()) + ".cs";
            var templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "template/NetModularDomain.txt");
            var content = ReadContext(templatePath);
            var newStr = content.Replace("{entityContent}", value);
            WriteContext(newStr, filePath);
        }

        private string ReadContext(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string context = sr.ReadToEnd();
            fs.Close();
            sr.Close();
            sr.Dispose();
            fs.Dispose();
            return context;
        }

        public void WriteContext(string Context, string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs); // 创建写入流
            sw.Write(Context);
            sw.Close();
            sw.Dispose();
            fs.Close();
            fs.Dispose();
        }
    }
}
