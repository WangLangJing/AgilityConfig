using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
namespace AgilityConfig
{
    /// <summary>
    /// 配置标签
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class, AllowMultiple = false)]
    public class ConfigTagAttribute : System.Attribute
    {
        /// <summary>
        /// 配置标签的友好名称
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 配置标签的详细描述
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// 配置标签所属类别
        /// </summary>
        public String Category { get; set; }
        /// <summary>
        /// 表示此标签是否可被发现，以显示在特定的管理工具中
        /// </summary>
        public Boolean IsFindable { get; set; }

        /// <summary>
        /// 表示此标签的值是否需要加密，只能作用于 <see cref="String"/> 类型，附加目标为其他类型时无效
        /// </summary>
        public Boolean IsEncrypted { get; set; }
    }
}
