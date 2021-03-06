﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OBear.EntityFramework;
using OBear.Initialize;
using OBear.Security;
using OJava;
using OJava.EntityFramework;
namespace OMap.Web.Mvc.Initialize
{
    /// <summary>
    /// MVC框架初始化器
    /// </summary>
    public class MvcFrameworkInitializer : FrameworkInitializerBase
    {
        /// <summary>
        /// 初始化一个<see cref="MvcFrameworkInitializer"/>类型的新实例
        /// </summary>
        public MvcFrameworkInitializer()
        {
            PlatformToken = PlatformToken.Mvc;
            DataConfigReseter = new DataConfigReseter<OJavaDbContext, OJavaDbContextInitializer>();
            DatabaseInitializer = new DatabaseInitializer<OJavaDbContext, OJavaDbContextInitializer>();
        }
    }
}