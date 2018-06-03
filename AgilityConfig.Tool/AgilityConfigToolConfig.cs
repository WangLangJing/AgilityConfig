using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgilityConfig.Tool
{
    public class AgilityConfigToolConfig : ConfigBase
    {
        /// <summary>
        /// 可配置项目列表
        /// </summary>
        [ConfigTag]
        public ConfigurableItem[] ConfigurableItems { get; set; }
    }
    /// <summary>
    /// 可配置项
    /// </summary>
    public class ConfigurableItem
    {
        /// <summary>
        /// 可配置项目的名称
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 可配置项对应的配置文件的路径
        /// </summary>
        public String Path { get; set; }
        /// <summary>
        /// 可配置项目对于的配置类
        /// </summary>
        public String Type { get; set; }

        /// <summary>
        /// 配置文件是否是加密的
        /// </summary>
        public Boolean IsEncrypted { get; set; }

        internal Type type { get; set; }
    }
}
