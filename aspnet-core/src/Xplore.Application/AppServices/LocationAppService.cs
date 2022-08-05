using System;
using System.Collections.Generic;
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
        IRepository<Location, Guid> _locationRepository;

        public LocationAppService(IRepository<Location, Guid> repository) :
            base(repository)
        {
            _locationRepository = repository;
        }

        [HttpGet("api/app/getLocationByType/{type}")]
        public async Task<List<Location>>
        GetscheduledtripWithDetailsAsync(LocationType type)
        {
            //Get a IQueryable<T> by including sub collections
            var queryable = await _locationRepository.GetQueryableAsync();

            //Apply additional LINQ extension methods
            var query = queryable.Where(x => x.Type == type);

            //Execute the query and get the result
            var res = await AsyncExecuter.ToListAsync(query);
            return res;
        }
    }
}
