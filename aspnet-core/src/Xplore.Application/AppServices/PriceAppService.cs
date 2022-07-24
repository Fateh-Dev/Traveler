using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Xplore.Models;

namespace Xplore.AppServices
{
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
