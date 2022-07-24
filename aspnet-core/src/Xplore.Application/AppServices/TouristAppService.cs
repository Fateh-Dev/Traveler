using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Xplore.Models;

namespace Xplore.AppServices
{
    public class
    TouristAppService
    :
    CrudAppService<Tourist, //The Book entity
        TouristDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateTouristDto
    >, //Used to create/update a book
    ITouristAppService //implement the IBookAppService
    {
        public TouristAppService(IRepository<Tourist, Guid> repository) :
            base(repository)
        {
        }
    }
}
