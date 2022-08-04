using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Xplore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Xplore.AppServices
{
    [ApiExplorerSettings(GroupName = "Xplorer_Api", IgnoreApi = false)]
    public class
    ScheduleAppService
    :
    CrudAppService<Schedule, //The Book entity
        ScheduleDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateScheduleDto
    >, //Used to create/update a book
    IScheduleAppService //implement the IBookAppService
    {
        public ScheduleAppService(IRepository<Schedule, Guid> repository) :
            base(repository)
        {
        }
    }
}
