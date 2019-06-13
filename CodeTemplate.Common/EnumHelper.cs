using CodeTemplate.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace CodeTemplate.Common
{
    public static class EnumHelper
    {
        public static List<EnumEntity> GetEnumEntityList(Type type)
        {
            var ret = new List<EnumEntity>();
            var valueList = Enum.GetValues(type);
            foreach (var value in Enum.GetValues(type))
            {
                ret.Add(new EnumEntity
                {
                    Name = value.ToString(),
                    Value = Convert.ToInt32(value),
                    Desc = GetDesc(value)
                });
            }
            return ret;
        }

        public static string GetDesc(object value)
        {
            Type e = value.GetType();
            FieldInfo field = e.GetField(value.ToString());
            DescriptionAttribute[] EnumAttributes = (DescriptionAttribute[])field.
                GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (EnumAttributes.Length > 0)
            {
                return EnumAttributes[0].Description;
            }
            else
            {
                return "";
            }
        }
    }
}