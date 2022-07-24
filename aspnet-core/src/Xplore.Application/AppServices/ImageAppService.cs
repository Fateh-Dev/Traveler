using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Xplore.Models;

namespace Xplore.AppServices
{
    public class
    ImageAppService
    :
    CrudAppService<Image, //The Book entity
        ImageDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateImageDto
    >, //Used to create/update a book
    IImageAppService //implement the IBookAppService
    {
        public ImageAppService(IRepository<Image, Guid> repository) :
            base(repository)
        {
        }
    }
}
