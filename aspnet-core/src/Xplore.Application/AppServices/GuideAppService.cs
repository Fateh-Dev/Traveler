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
        private readonly IRepository<Guide, Guid> _guideRepository;

        public GuideAppService(IRepository<Guide, Guid> repository) :
            base(repository)
        {
            _guideRepository = repository;
        }

        [HttpGet("api/app/getGuideWithDetails/{id}")]
        public async Task<GuideDto> GetGuideWithDetailsAsync(Guid id)
        {
            //Get a IQueryable<T> by including sub collections
            var queryable =
                await _guideRepository.WithDetailsAsync(z => z.Trips);

            //Apply additional LINQ extension methods
            var query = queryable.Where(x => x.Id == id);

            //Execute the query and get the result
            var res = await AsyncExecuter.FirstOrDefaultAsync(query);

            return ObjectMapper.Map<Guide, GuideDto>(res);
        }
    }
}
