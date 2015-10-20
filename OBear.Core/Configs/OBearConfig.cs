using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OBear.Configs.ConfigFile;

namespace OBear.Configs
{
    /// <summary>
    /// OBear配置类
    /// </summary>
    public sealed class OBearConfig
    {
        private static readonly Lazy<OBearConfig> InstanceLazy
            = new Lazy<OBearConfig>(() => new OBearConfig());
        private const string OBearSectionName = "obear";

        /// <summary>
        /// 初始化一个心得<see cref="OBearConfig"/>实例
        /// </summary>
        private OBearConfig()
        {
            OBearFrameworkSection section = (OBearFrameworkSection)ConfigurationManager.GetSection(OBearSectionName);
            if (section == null)
            {
                DataConfig = new DataConfig();
                return;
            }
            DataConfig = new DataConfig(section.Data);
        }

        /// <summary>
        /// 获取 配置类的单一实例
        /// </summary>
        public static OBearConfig Instance
        {
            get { return InstanceLazy.Value; }
        }

        /// <summary>
        /// 获取或设置 数据配置信息
        /// </summary>
        public DataConfig DataConfig { get; set; }
    }
}

