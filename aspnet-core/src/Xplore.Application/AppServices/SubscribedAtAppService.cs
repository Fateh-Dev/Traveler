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
    SubscribeAtAppService
    :
    CrudAppService<SubscribeAt, //The Book entity
        SubscribeAtDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateSubscribeAtDto
    >, //Used to create/update a book
    ISubscribeAtAppService //implement the IBookAppService
    {
        public SubscribeAtAppService(IRepository<SubscribeAt, Guid> repository) :
            base(repository)
        {
        }
    }
}
