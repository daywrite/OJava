using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OBear.Configs;
using OBear.Configs.ConfigFile;
using OBear.Security;

namespace OBear.Initialize
{
    /// <summary>
    /// 框架初始化基类
    /// </summary>
    public abstract class FrameworkInitializerBase : IFrameworkInitializer
    {
        //基础模块，只初始化一次
        private static bool _basicLoggingInitialized;
        private static bool _databaseInitialized;
        private static bool _entityInfoInitialized;


        /// <summary>
        /// 获取或设置 当前运行平台标识
        /// </summary>
        public PlatformToken PlatformToken { get; set; }

        /// <summary>
        /// 获取或设置 数据配置重置者
        /// </summary>
        public IDataConfigReseter DataConfigReseter { get; set; }

        /// <summary>
        /// 获取或设置 数据库初始化器
        /// </summary>
        public IDatabaseInitializer DatabaseInitializer { get; set; }

        /// <summary>
        /// 开始初始化
        /// </summary>
        public void Initialize()
        {
            OBearConfig config = ResetConfig(OBearConfig.Instance);

            if (!_databaseInitialized)
            {
                if (DatabaseInitializer == null)
                {
                    //throw new InvalidOperationException(Resources.FrameworkInitializerBase_DatabaseInitializeIsNull);
                }
                DatabaseInitializer.Initialize(config.DataConfig);
                _databaseInitialized = true;
            }
        }

        /// <summary>
        /// 重写以实现重置OBear配置信息
        /// </summary>
        /// <param name="config">原始配置信息</param>
        /// <returns>重置后的配置信息</returns>
        protected OBearConfig ResetConfig(OBearConfig config)
        {
            if (DataConfigReseter != null)
            {
                config.DataConfig = DataConfigReseter.Reset(config.DataConfig);
            }
            return config;
        }
    }
}

