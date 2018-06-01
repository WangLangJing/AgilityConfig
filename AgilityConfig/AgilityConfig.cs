using System;
using System.Collections.Generic;
using System.Text;
namespace AgilityConfig
{
    public class AgilityConfig
    {
        public AgilityConfig(Type configType)
        {

        }
    }
    public class AgilityConfig<T> : AgilityConfig where T : ConfigBaseObject, new()
    {
        /// <summary>
        /// 从指定路径加载配置对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <param name="encrypted">表示文件是否被加密</param>
        /// <returns></returns>
        public static T LoadConfig(String filePath, Boolean encrypted = false)
        {
            T obj = null;
            return obj;
        }
        /// <summary>
        /// 将配置对象保存到指定路径
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="savePath">保存路径  </param>
        /// <param name="encrypted">表示是否需要加密</param>
        public static void SaveConfig(T obj, String savePath, Boolean isEncrypted = false)
        {



        }
        private static void AnalyzeConfigObject(T obj)
        {
            T newObj = new T();

        }
        public static void DeepClone(T obj)
        {

        }
    }
}
