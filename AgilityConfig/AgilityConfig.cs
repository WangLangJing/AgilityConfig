using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;

namespace AgilityConfig
{
    public class AgilityConfig
    {
        static Encoding _DefaultEncodeing;
        static AgilityConfig()
        {
            _DefaultEncodeing = UTF8Encoding.UTF8;
        }
        public static void LoadConfigToObject(Object obj, Type type, String filePath, Boolean isEncrypted = false)
        {
            Object target = null;

            var text = File.ReadAllText(filePath, _DefaultEncodeing);
            if (isEncrypted)
            {
                text = StringEncryptor.Decrypt(text);
            }
            target = SerializeAssistor.Deserialize(text, type);

            var propertyInfos = TypeInfoProvider.GetProperties(type);

            foreach (var prop in propertyInfos)
            {
                var configTag = TypeInfoProvider.GetConfigTag(prop);
                if (configTag != null)
                {
                    Object value = TypeInfoProvider.GetValue(prop, target);
                    if (configTag.IsEncrypted && value != null && prop.PropertyType == typeof(String))
                    {
                        String strValue = value as String;
                        strValue = StringEncryptor.Decrypt(strValue);
                        TypeInfoProvider.SetValue(prop, obj, strValue);
                    }
                    else
                    {
                        TypeInfoProvider.SetValue(prop, obj, value);
                    }
                }
            }
        }
        /// <summary>
        /// 从指定路径加载配置对象
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="isEncrypted">表示文件是否被加密</param>
        /// <returns></returns>
        public static Object LoadConfig(Type type, String filePath, Boolean isEncrypted = false)
        {
            Object target = TypeInfoProvider.CreateInstance(type);
            LoadConfigToObject(target, type, filePath, isEncrypted);
            return target;
        }
        public static T LoadConfig<T>( String filePath, Boolean isEncrypted = false) where T: ConfigBase
        {
            Type type = typeof(T);
            Object target = TypeInfoProvider.CreateInstance(typeof(T));
            LoadConfigToObject(target, type, filePath, isEncrypted);
            return target as T;
        }
        /// <summary>
        /// 将配置对象保存到指定路径
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="savePath">保存路径  </param>
        /// <param name="isEncrypt">表示是否需要加密</param>
        public static void SaveConfig(Object obj, Type type, String savePath, Boolean isEncrypt = false)
        {

            Object target = obj;
            Object cloenTarget = Activator.CreateInstance(type);
            var propertyInfos = TypeInfoProvider.GetProperties(type);

            foreach (var prop in propertyInfos)
            {
                var configTag = TypeInfoProvider.GetConfigTag(prop);
                if (configTag != null)
                {
                    Object value = TypeInfoProvider.GetValue(prop, target);
                    if (configTag.IsEncrypted && value != null && prop.PropertyType == typeof(String))
                    {
                        String strValue = value as String;
                        strValue = StringEncryptor.Encrypt(strValue);
                        TypeInfoProvider.SetValue(prop, cloenTarget, strValue);
                    }
                    else
                    {
                        TypeInfoProvider.SetValue(prop, cloenTarget, value);
                    }
                
                }
            }

            var text = SerializeAssistor.Serialize(cloenTarget, type);
            if (isEncrypt)
            {
                text = StringEncryptor.Decrypt(text);
            }
            File.WriteAllText(savePath, text, _DefaultEncodeing);

        }
    }

}
