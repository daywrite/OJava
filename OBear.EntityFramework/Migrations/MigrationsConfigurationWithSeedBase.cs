﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.Migrations;
using System.Data.Entity;

namespace OBear.EntityFramework.Migrations
{
    /// <summary>
    /// 数据迁移配置基类
    /// </summary>
    public abstract class MigrationsConfigurationWithSeedBase<TDbContext> : DbMigrationsConfiguration<TDbContext> 
        where TDbContext : DbContext
    {
        /// <summary>
        /// 初始化一个<see cref="MigrationsConfigurationWithSeedBase{TDbContext}"/>类型的新实例
        /// </summary>
        protected MigrationsConfigurationWithSeedBase()
        {
            SeedActions = new List<ISeedAction>();
        }

        /// <summary>
        /// 获取 数据迁移初始化种子数据操作信息集合，各个模块可以添加自己的数据初始化操作
        /// </summary>
        public ICollection<ISeedAction> SeedActions { get; private set; }

        protected override void Seed(TDbContext context)
        {
            IEnumerable<ISeedAction> seedActions = SeedActions.OrderBy(m => m.Order);
            foreach (ISeedAction seedAction in seedActions)
            {
                seedAction.Action(context);
            }
        }
    }
}
