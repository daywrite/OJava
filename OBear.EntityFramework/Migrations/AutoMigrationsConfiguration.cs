using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace OBear.EntityFramework.Migrations
{
    /// <summary>
    /// �Զ�Ǩ������
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    public class AutoMigrationsConfiguration<TContext> : DbMigrationsConfiguration<TContext>
        where TContext : DbContext
    {
        /// <summary>
        /// ��ʼ��һ��<see cref="AutoMigrationsConfiguration{TContext}"/>���͵���ʵ��
        /// </summary>
        public AutoMigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = typeof(TContext).FullName;
        }
    }
}
