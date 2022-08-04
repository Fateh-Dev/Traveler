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
    PriceAppService
    :
    CrudAppService<Price, //The Book entity
        PriceDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdatePriceDto
    >, //Used to create/update a book
    IPriceAppService //implement the IBookAppService
    {
        public PriceAppService(IRepository<Price, Guid> repository) :
            base(repository)
        {
        }
    }
}
