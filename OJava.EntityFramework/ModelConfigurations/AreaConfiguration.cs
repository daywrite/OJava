using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OJava.Models;

namespace OJava.ModelConfigurations
{
    public class AreaConfiguration : EntityConfigurationBase<Area, int>
    {
        public AreaConfiguration()
        {
            Property(c => c.经度).HasColumnType("float");
            Property(c => c.纬度).HasColumnType("float");
        }
    }
}
