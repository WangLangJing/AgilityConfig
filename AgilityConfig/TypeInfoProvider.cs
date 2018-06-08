using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.ComponentModel;

namespace AgilityConfig
{
    public class TypeInfoProvider
    {
        public static Object CreateInstance(Type type)
        {

            return Activator.CreateInstance(type);

        }
        public static IEnumerable<PropertyInfo> GetProperties(Type type)
        {
            return type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
        }
        public static void SetValue(PropertyInfo info, Object target, Object value)
        {
#if NET40
            info.SetValue(target, value, null);
#endif
#if NETCOREAPP2_0
            info.SetValue(target, value);
#endif
        }
        public static Object GetValue(PropertyInfo info, Object target)
        {
            return info.GetValue(target, null);
        }
        public static ConfigTagAttribute GetConfigTag(PropertyInfo info)
        {
            ConfigTagAttribute attribute = null;
#if NET40
            var attrs = info.GetCustomAttributes(typeof(ConfigTagAttribute), false);
            if (attrs.Length > 0)
            {
                attribute = attrs[0] as ConfigTagAttribute;
            }
#endif
#if NETCOREAPP2_0
          attribute= info.GetCustomAttribute(typeof(ConfigTagAttribute)) as ConfigTagAttribute;
#endif
            return attribute;
        }
    }
}
