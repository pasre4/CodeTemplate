namespace CodeTemplate.Entity
{
    public class DbCombobox
    {
        /// <summary>
        /// 数据库名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 数据库类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 读库
        /// </summary>
        public string Read { get; set; }

        /// <summary>
        /// 写库
        /// </summary>
        public string Write { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}