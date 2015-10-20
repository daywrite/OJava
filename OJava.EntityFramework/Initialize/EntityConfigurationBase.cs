﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using OBear.EntityFramework;

namespace OJava
{
    /// <summary>
    /// 数据实体映射配置基类
    /// </summary>
    /// <typeparam name="TEntity">动态实体类型</typeparam>
    /// <typeparam name="TKey">动态主键类型</typeparam>
    public abstract class EntityConfigurationBase<TEntity, TKey> : EntityTypeConfiguration<TEntity>, IEntityMapper
        where TEntity : class, IEntity<TKey>
    {
        /// <summary>
        /// 获取 相关上下文类型，如为null，将使用默认上下文<see cref="DefaultDbContext"/>，否则使用指定的上下文类型
        /// </summary>
        public virtual Type DbContextType
        {
            get { return null; }
        }

        /// <summary>
        /// 将当前实体映射对象注册到当前数据访问上下文实体映射配置注册器中
        /// </summary>
        /// <param name="configurations">实体映射配置注册器</param>
        public void RegistTo(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
        }
    }


    /// <summary>
    /// 复合数据实体映射配置基类
    /// </summary>
    /// <typeparam name="TComplexType">动态复合实体类型</typeparam>
    /// <typeparam name="TKey">动态主键类型</typeparam>
    public abstract class ComplexTypeConfigurationBase<TComplexType, TKey> : ComplexTypeConfiguration<TComplexType>, IEntityMapper
        where TComplexType : class, IEntity<TKey>
    {
        /// <summary>
        /// 获取 相关上下文类型，如为null，将使用默认上下文，否则使用指定的上下文类型
        /// </summary>
        public virtual Type DbContextType
        {
            get { return null; }
        }

        /// <summary>
        /// 将当前实体映射对象注册到当前数据访问上下文实体映射配置注册器中
        /// </summary>
        /// <param name="configurations">实体映射配置注册器</param>
        public void RegistTo(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
        }
    }
}
