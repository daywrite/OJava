﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OBear.EntityFramework;

namespace OBear.EntityFramework
{
    /// <summary>
    /// 数据上下文管理器
    /// </summary>
    public sealed class DbContextManager
    {
        private static readonly Lazy<DbContextManager> InstanceLazy = new Lazy<DbContextManager>(() => new DbContextManager());

        /// <summary>
        /// 上下文类型-上下文初始化类型
        /// </summary>
        private readonly IDictionary<Type, DbContextInitializerBase> _contextInitializerDict
            = new Dictionary<Type, DbContextInitializerBase>();
        private readonly ConcurrentDictionary<Type, Type> _entityContextCache = new ConcurrentDictionary<Type, Type>();

        /// <summary>
        /// 获取 上下文管理器的唯一实例
        /// </summary>
        public static DbContextManager Instance { get { return InstanceLazy.Value; } }

        /// <summary>
        /// 注册上下文初始化器
        /// </summary>
        /// <param name="contextType">上下文类型</param>
        /// <param name="initializer">上下文初始化器</param>
        public void RegisterInitializer(Type contextType, DbContextInitializerBase initializer)
        {
            if (_contextInitializerDict.ContainsKey(contextType))
            {
                return;
            }
            _contextInitializerDict[contextType] = initializer;
            initializer.Initialize();
        }
        /// <summary>
        /// 获取 实体映射集合
        /// </summary>
        /// <param name="dbContextType">上下文类型</param>
        /// <returns>实体集合</returns>
        /// <exception cref="InvalidOperationException">如果<c>dbContextType</c>不存在则抛出<c>InvalidOperationException</c>异常</exception>
        public IEnumerable<IEntityMapper> GetEntityMappers(Type dbContextType)
        {
            //dbContextType.CheckNotNull("dbContextType");
            //if (!typeof(DbContextBase<>).IsGenericAssignableFrom(dbContextType))
            //{
            //    throw new InvalidOperationException(Resources.DbContextManager_TypeNotDbContextType.FormatWith(dbContextType.FullName));
            //}

            DbContextInitializerBase initializer;
            if (_contextInitializerDict.TryGetValue(dbContextType, out initializer))
            {
                return initializer.EntityMappers.Values;
            }
            return new List<IEntityMapper>();
        }
    }
}
