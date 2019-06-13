namespace CodeTemplate.Entity
{
    public class TableModel
    {
        /// <summary>
        /// 表名
        /// </summary>
        public string Name { get; set; }


        public override string ToString()
        {
            return this.Name;
        }
    }
}