using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace AgilityConfig.Tool
{
    public class SampleConfig: ConfigBase
    {
        [ConfigTag(Name = "名称", Description = "主要数据库的连接字符串", IsFindable = true, Category = "测试",IsEncrypted =true)]
        public String Name { get; set; }


        [ConfigTag(Name = "子配置", Description = "子类配置", IsFindable = true,Category = "测试")]
        public SampleConfig2 Childrens { get; set; }

        [ConfigTag(Name = "可配置班级", Description = "所有可配置班级的名称", IsFindable = true, Category = "测试")]
        public String[] Classes { get; set; }

        [ConfigTag(Name = "开始时间", Description = "开始时间", IsFindable = true, Category = "测试")]
        public DateTime DateTime { get; set; } = DateTime.Now;

        [ConfigTag(Name = "超时时间", Description = "超时时间", IsFindable = false, Category = "测试")]
        public TimeSpan TimeOut { get; set; }

        [ConfigTag(Name = "最大连接数量", Description = "表示客户端最大的连接数", IsFindable = true, Category = "测试")]
        public Int32 MaxConnectLength { get; set; }

        [ConfigTag(Name = "最大误差", Description = "表示计算结果有效的最大误差，小数位后2位", IsFindable = true, Category = "测试")]
        public Double MaxDeviation { get; set; }
    }
  
    public class SampleConfig2:ConfigBase
    {
        [ConfigTag(Name = "名称", Description = "测试 ", IsFindable = true, Category = "测试")]
        public String Name { get; set; }
    }
}
