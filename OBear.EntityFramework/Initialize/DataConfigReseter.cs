﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OBear;
using OBear.Configs;
using OBear.Configs.ConfigFile;
using OBear.EntityFramework;
//using OJava.EntityFramework;
using OBear.Reflection;


namespace OBear.EntityFramework
{
    /// <summary>
    /// 数据配置信息重置类
    /// </summary>
    public class DataConfigReseter<A,B> : IDataConfigReseter
    {
        /// <summary>
        /// 初始化一个<see cref="DataConfigReseter"/>类型的新实例
        /// </summary>
        public DataConfigReseter()
        {
            MapperAssemblyFinder = new EntityMapperAssemblyFinder();
        }

        /// <summary>
        /// 获取或设置 实体映射程序集查找器
        /// </summary>
        public IAssemblyFinder MapperAssemblyFinder { get; set; }

        /// <summary>
        /// 重置数据配置信息
        /// </summary>
        /// <param name="config">原始数据配置信息</param>
        /// <returns>重置后的数据配置信息</returns>
        public DataConfig Reset(DataConfig config)
        {
            //没有上下文，添加默认上下文
            if (!config.ContextConfigs.Any())
            {
                DbContextConfig contextConfig = GetDefaultDbContextConfig();
                config.ContextConfigs.Add(contextConfig);
            }
            //如果业务上下文存在开启数据日志功能，并且日志上下文没有设置，则添加日志上下文
            //if (config.ContextConfigs.All(m => m.ContextType != typeof(LoggingDbContext)))
            //{
            //    DbContextConfig contextConfig = GetLoggingDbContextConfig();
            //    config.ContextConfigs.Add(contextConfig);
            //}
            return config;
        }

        /// <summary>
        /// 获取默认业务上下文配置信息
        /// </summary>
        /// <returns></returns>
        protected virtual DbContextConfig GetDefaultDbContextConfig()
        {
            return new DbContextConfig()
            {
                ConnectionStringName = "default",
                ContextType = typeof(A),
                InitializerConfig = new DbContextInitializerConfig()
                {
                    InitializerType = typeof(B),
                    EntityMapperAssemblies = MapperAssemblyFinder.FindAll()
                }
            };
        }

        /// <summary>
        /// 获取默认日志上下文配置信息
        /// </summary>
        /// <returns></returns>
        //protected virtual DbContextConfig GetLoggingDbContextConfig()
        //{
        //    return new DbContextConfig()
        //    {
        //        ConnectionStringName = "default",
        //        ContextType = typeof(LoggingDbContext),
        //        InitializerConfig = new DbContextInitializerConfig()
        //        {
        //            InitializerType = typeof(LoggingDbContextInitializer),
        //            EntityMapperAssemblies = { typeof(LoggingDbContext).Assembly }
        //        }
        //    };
        //}

    }
}
