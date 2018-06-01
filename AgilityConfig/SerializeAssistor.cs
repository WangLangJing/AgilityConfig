using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
namespace AgilityConfig
{
    public static class SerializeAssistor
    {
        /// <summary>
        /// 将指定对象序列化为字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static String Serialize(Object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        /// <summary>
        /// 将指定字符串反列化为 <see cref="ConfigBaseObject"/> 派生类的实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public static T Deserialize<T>(String str) where T : ConfigBaseObject
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
    }
}
