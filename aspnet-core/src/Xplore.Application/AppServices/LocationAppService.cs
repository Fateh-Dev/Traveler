using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Xplore.Models;

namespace Xplore.AppServices
{
    public class
    LocationAppService
    :
    CrudAppService<Location, //The Book entity
        LocationDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateLocationDto
    >, //Used to create/update a book
    ILocationAppService //implement the IBookAppService
    {
        public LocationAppService(IRepository<Location, Guid> repository) :
            base(repository)
        {
        }
    }
}
