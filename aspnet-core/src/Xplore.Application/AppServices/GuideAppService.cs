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
    GuideAppService
    :
    CrudAppService<Guide, //The Book entity
        GuideDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateGuideDto
    >, //Used to create/update a book
    IGuideAppService //implement the IBookAppService
    {
        public GuideAppService(IRepository<Guide, Guid> repository) :
            base(repository)
        {
        }
    }
}
