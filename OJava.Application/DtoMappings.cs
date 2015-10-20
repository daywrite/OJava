using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using OJava.Models.Tasks;
using OJava.Tasks.Dtos;

namespace OJava
{
    internal static class DtoMappings
    {
        public static void Map()
        {
            //I specified mapping for AssignedPersonId since NHibernate does not fill Task.AssignedPersonId
            //If you will just use EF, then you can remove ForMember definition.
            Mapper.CreateMap<Task, TaskDto>().ForMember(t => t.AssignedPersonId, opts => opts.MapFrom(d => d.AssignedPerson.Id));
        }
    }
}

