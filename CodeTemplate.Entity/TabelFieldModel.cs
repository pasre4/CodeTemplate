using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTemplate.Entity
{
    public class TabelFieldModel
    {
        /// <summary>
        /// 字段名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 字段类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 是否主键
        /// </summary>
        public bool IsPrimary { get; set; }

        /// <summary>
        /// 是否自增
        /// </summary>
        public bool IsCreasing { get; set; }

        /// <summary>
        /// 是否允许空值
        /// </summary>
        public bool IsNull { get; set; }

        /// <summary>
        /// 字段长度
        /// </summary>
        public int FieldLength { get; set; }
    }
}
