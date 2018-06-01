using System;
using System.Collections.Generic;
using System.Text;

namespace AgilityConfig
{
    /// <summary>
    /// 表示忽略指定的配置标签
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class IgnoreAttribute : System.Attribute
    {

    }
}
