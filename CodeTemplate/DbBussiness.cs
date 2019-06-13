using System.Configuration;

namespace CodeTemplate
{
    public class DbBussiness : ConfigurationSection
    {
        [ConfigurationProperty("contexts", IsRequired = true)]
        [ConfigurationCollection(typeof(DbBusinessItem))]
        public DbBusinessItemCollection List
        {
            get { return this["contexts"] as DbBusinessItemCollection; }
            internal set { this["contexts"] = value; }
        }
    }

    public class DbBusinessItemCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new DbBusinessItem();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return element.GetHashCode();
        }
    }

    public class DbBusinessItem : ConfigurationElement
    {
        /// <summary>
        /// 数据库名称
        /// </summary>
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return this["name"].ToString(); }
            internal set { this["name"] = value; }
        }

        /// <summary>
        /// 数据库类型
        /// </summary>
        [ConfigurationProperty("type", IsRequired = true)]
        public string Type
        {
            get { return this["type"].ToString(); }
            internal set { this["type"] = value; }
        }

        /// <summary>
        /// 读库
        /// </summary>
        [ConfigurationProperty("read", IsRequired = true)]
        public string Read
        {
            get { return this["read"].ToString(); }
            internal set { this["read"] = value; }
        }

        /// <summary>
        /// 写库
        /// </summary>
        [ConfigurationProperty("write", IsRequired = true)]
        public string Write
        {
            get { return this["write"].ToString(); }
            internal set { this["write"] = value; }
        }
    }
}