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
    TripAppService
    :
    CrudAppService<Trip, //The Book entity
        TripDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateTripDto
    >, //Used to create/update a book
    ITripAppService //implement the IBookAppService
    {
        private readonly IRepository<Trip, Guid> _tripRepository;

        public TripAppService(IRepository<Trip, Guid> repository) :
            base(repository)
        {
            _tripRepository = repository;
        }

        public override async Task<TripDto> GetAsync(Guid id)
        {
            //Get a IQueryable<T> by including sub collections
            var queryable =
                await _tripRepository
                    .WithDetailsAsync(z => z.Locations,
                    e => e.Images,
                    s => s.Prices);

            //Apply additional LINQ extension methods
            var query = queryable.Where(x => x.Id == id);

            //Execute the query and get the result
            var trip = await AsyncExecuter.FirstOrDefaultAsync(query);

            return ObjectMapper.Map<Trip, TripDto>(trip);
        }
    }
}
