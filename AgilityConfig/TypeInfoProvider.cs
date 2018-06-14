﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using System.IO;

namespace AgilityConfig
{
    public class TypeInfoProvider
    {
        public static Type GetType(String typeStr)
        {
            return Type.GetType(typeStr);
            //String[] splitInfo = typeStr.Split(',');
            //Type type = null;
            //if (splitInfo.Length == 2)
            //{
            //    String assemblyFileName = splitInfo[0];
            //    if (!assemblyFileName.EndsWith(".dll") && !assemblyFileName.EndsWith(".exe"))
            //    {
            //        String temp = assemblyFileName + ".exe";
            //        if (File.Exists(temp))
            //        {
            //            assemblyFileName = temp;
            //        }
            //        else
            //        {
            //            assemblyFileName = ".dll";
            //        }
            //    }
            //    String assemblyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, assemblyFileName);
            //    String typeName = splitInfo[1];

            //    var assembly = Assembly.LoadFrom(assemblyPath);
            //    type = assembly.GetType(typeName);
            //}
            //return type;
        }
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

            info.SetValue(target, value, null);


        }
        public static Object GetValue(PropertyInfo info, Object target)
        {
            return info.GetValue(target, null);
        }
        public static ConfigTagAttribute GetConfigTag(PropertyInfo info)
        {
            ConfigTagAttribute attribute = null;

            var attrs = info.GetCustomAttributes(typeof(ConfigTagAttribute), false);
            if (attrs.Length > 0)
            {
                attribute = attrs[0] as ConfigTagAttribute;
            }

            return attribute;
        }
    }
}
