﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OBear.Core.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OBear.Core.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 缓存功能尚未初始化，未找到可用的 ICacheProvider 实现。 的本地化字符串。
        /// </summary>
        public static string Caching_CacheNotInitialized {
            get {
                return ResourceManager.GetString("Caching_CacheNotInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 标识为“{0}”的项重复定义 的本地化字符串。
        /// </summary>
        public static string ConfigFile_ItemKeyDefineRepeated {
            get {
                return ResourceManager.GetString("ConfigFile_ItemKeyDefineRepeated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 上下文初始化类型“{0}”不存在 的本地化字符串。
        /// </summary>
        public static string DbContextInitializerConfig_InitializerNotExists {
            get {
                return ResourceManager.GetString("DbContextInitializerConfig_InitializerNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 数据库初始化器不能为空，请为框架初始化类的DatabaseInitializer属性赋值 的本地化字符串。
        /// </summary>
        public static string FrameworkInitializerBase_DatabaseInitializeIsNull {
            get {
                return ResourceManager.GetString("FrameworkInitializerBase_DatabaseInitializeIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 数据处理初始化器不能为空，请为框架初始化类的EntityInfoHandler属性赋值 的本地化字符串。
        /// </summary>
        public static string FrameworkInitializerBase_EntityInfoHandlerIsNull {
            get {
                return ResourceManager.GetString("FrameworkInitializerBase_EntityInfoHandlerIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 数据处理初始化器不能为空，请为框架初始化类的FunctionHandler属性赋值 的本地化字符串。
        /// </summary>
        public static string FrameworkInitializerBase_FunctionHandlerIsNull {
            get {
                return ResourceManager.GetString("FrameworkInitializerBase_FunctionHandlerIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 依赖注入初始化器不能为空，请为框架初始化类的IocInitializer属性赋值 的本地化字符串。
        /// </summary>
        public static string FrameworkInitializerBase_IocInitializeIsNull {
            get {
                return ResourceManager.GetString("FrameworkInitializerBase_IocInitializeIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 类型“{0}”不是仓储接口“IRepository&lt;,&gt;”的派生类。 的本地化字符串。
        /// </summary>
        public static string IocInitializerBase_TypeNotIRepositoryType {
            get {
                return ResourceManager.GetString("IocInitializerBase_TypeNotIRepositoryType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 类型“{0}”不是实体类型 的本地化字符串。
        /// </summary>
        public static string QueryCacheExtensions_TypeNotEntityType {
            get {
                return ResourceManager.GetString("QueryCacheExtensions_TypeNotEntityType", resourceCulture);
            }
        }
    }
}
