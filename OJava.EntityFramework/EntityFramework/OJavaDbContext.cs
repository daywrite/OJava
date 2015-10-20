using System.Data.Entity;
using Abp.EntityFramework;
using OJava.Models;
using OJava.Models.People;
using OJava.Models.Tasks;

namespace OJava.EntityFramework
{
    public class OJavaDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }
        public virtual IDbSet<Area> Areas { get; set; }
        public virtual IDbSet<Person> Persons { get; set; }
        public virtual IDbSet<Task> Tasks { get; set; }
        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public OJavaDbContext()
            : base("default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in OJavaDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of OJavaDbContext since ABP automatically handles it.
         */
        public OJavaDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
