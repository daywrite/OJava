﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OBear.Reflection;

namespace OBear.EntityFramework
{
    /// <summary>
    /// 实体映射程序集查找器
    /// </summary>
    public class EntityMapperAssemblyFinder : IAssemblyFinder
    {
        /// <summary>
        /// 初始化一个<see cref="EntityMapperAssemblyFinder"/>类型的新实例
        /// </summary>
        public EntityMapperAssemblyFinder()
        {
            AllAssemblyFinder = new CurrentDomainAssemblyFinder();
        }

        /// <summary>
        /// 获取或设置 所有程序集查找器
        /// </summary>
        public IAssemblyFinder AllAssemblyFinder { get; set; }

        /// <summary>
        /// 查找指定条件的项
        /// </summary>
        /// <param name="predicate">筛选条件</param>
        /// <returns></returns>
        public Assembly[] Find(Func<Assembly, bool> predicate)
        {
            return FindAll().Where(predicate).ToArray();
        }

        /// <summary>
        /// 查找所有项
        /// </summary>
        /// <returns></returns>
        public Assembly[] FindAll()
        {
            Type baseType = typeof(IEntityMapper);
            Assembly[] assemblies = AllAssemblyFinder.Find(assembly =>
                assembly.GetTypes().Any(type => baseType.IsAssignableFrom(type) && !type.IsAbstract));
            return assemblies;
        }
    }
}
