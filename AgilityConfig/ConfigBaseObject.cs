using System;

namespace AgilityConfig
{
    /// <summary>
    /// 配置基础对象
    /// </summary>
    [Serializable]
    public abstract class ConfigBaseObject
    {
        public ConfigBaseObject() { }

        public void Save(String filePath)
        {
            Type type=this.GetType();
        }
    }
}
