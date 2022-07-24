using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Xplore.Models;

namespace Xplore.AppServices
{
    public class
    RatingAppService
    :
    CrudAppService<Rating, //The Book entity
        RatingDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateRatingDto
    >, //Used to create/update a book
    IRatingAppService //implement the IBookAppService
    {
        public RatingAppService(IRepository<Rating, Guid> repository) :
            base(repository)
        {
        }
    }
}
