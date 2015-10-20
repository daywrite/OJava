using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using OJava.Models.People;

namespace OJava.People.Dtos
{
    [AutoMapFrom(typeof(Person))] //AutoMapFrom attribute maps Person -> PersonDto
    public class PersonDto : EntityDto
    {
        public string Name { get; set; }
    }
}
