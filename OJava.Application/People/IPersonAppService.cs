using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using OJava.People.Dtos;

namespace OJava.People
{
    public interface IPersonAppService : IApplicationService
    {
        Task<GetAllPeopleOutput> GetAllPeople();
    }
}

