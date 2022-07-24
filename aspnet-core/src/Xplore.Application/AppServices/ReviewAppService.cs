using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Xplore.Models;

namespace Xplore.AppServices
{
    public class
    ReviewAppService
    :
    CrudAppService<Review, //The Book entity
        ReviewDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateReviewDto
    >, //Used to create/update a book
    IReviewAppService //implement the IBookAppService
    {
        public ReviewAppService(IRepository<Review, Guid> repository) :
            base(repository)
        {
        }
    }
}
