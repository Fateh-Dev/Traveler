using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Xplore.Models;

namespace Xplore.AppServices
{
    [ApiExplorerSettings(GroupName = "Xplorer_Api", IgnoreApi = false)]
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
        public IRepository<Review, Guid> _reviewRepository;

        public ReviewAppService(IRepository<Review, Guid> repository) :
            base(repository)
        {
            _reviewRepository = repository;
        }

        [HttpGet("api/app/getReviewWithDetails/{id}")]
        public async Task<ReviewDto> GetReviewWithDetailsAsync(Guid id)
        {
            //Get a IQueryable<T> by including sub collections
            var queryable =
                await _reviewRepository.WithDetailsAsync(z => z.Ratings);

            //Apply additional LINQ extension methods
            var query = queryable.Where(x => x.Id == id);

            //Execute the query and get the result
            var res = await AsyncExecuter.FirstOrDefaultAsync(query);

            return ObjectMapper.Map<Review, ReviewDto>(res);
        }
    }
}
