using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Xplore.Models;

namespace Xplore.AppServices
{
    public class
    EnumerationAppService
    :
    CrudAppService<Enumeration, //The Book entity
        EnumerationDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateEnumerationDto
    >, //Used to create/update a book
    IEnumerationAppService //implement the IBookAppService
    {
        public EnumerationAppService(IRepository<Enumeration, Guid> repository) :
            base(repository)
        {
        }
    }
}
