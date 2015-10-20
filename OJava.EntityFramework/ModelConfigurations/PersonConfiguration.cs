using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OJava.Models.People;

namespace OJava.ModelConfigurations
{
     public class PersonConfiguration : EntityConfigurationBase<Person, int>
    {
         public PersonConfiguration()
        {            
        }
    }
}
