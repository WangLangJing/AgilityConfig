using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgilityConfig
{
    public abstract class ConfigBase
    {
        /// <summary>
        /// 从磁盘文件中加载配置信息到此实例
        /// </summary>
        public void Load(String filePath, Boolean isEncrypted = false)
        {
            Type type = this.GetType();
            AgilityConfig.LoadConfigToObject(this, type, filePath, isEncrypted);
        }
        /// <summary>
        /// 保存此实例包含的配置信息到磁盘文件
        /// </summary>
        public void Save(String savePath, Boolean isEncrypt = false)
        {
            Type type = this.GetType();
            AgilityConfig.SaveConfig(this, type, savePath, isEncrypt);
        }
    }
}
