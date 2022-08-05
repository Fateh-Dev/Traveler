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
    ScheduledTripAppService
    :
    CrudAppService<ScheduledTrip, //The Book entity
        ScheduledTripDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateScheduledTripDto
    >, //Used to create/update a book
    IScheduleAppService //implement the IBookAppService
    {
        private readonly IRepository<ScheduledTrip, Guid>
            _scheduledTripRepository;

        public ScheduledTripAppService(
            IRepository<ScheduledTrip, Guid> repository
        ) :
            base(repository)
        {
            _scheduledTripRepository = repository;
        }

        [HttpGet("api/app/getScheduledTripWithDetails/{id}")]
        public async Task<ScheduledTripDto>
        GetscheduledtripWithDetailsAsync(Guid id)
        {
            //Get a IQueryable<T> by including sub collections
            var queryable =
                await _scheduledTripRepository
                    .WithDetailsAsync(z => z.Prices,
                    x => x.Reviews,
                    d => d.subscribedTourists,
                    f => f.Trip);

            //Apply additional LINQ extension methods
            var query = queryable.Where(x => x.Id == id);

            //Execute the query and get the result
            var res = await AsyncExecuter.FirstOrDefaultAsync(query);

            return ObjectMapper.Map<ScheduledTrip, ScheduledTripDto>(res);
        }

        // [HttpGet("getTripSchedule")]
        // public async Task<List<ScheduledTrip>> GetScheduleAsync(Guid IdTrip)
        // {
        //     //Get a IQueryable<T> by including sub collections
        //     var queryable =
        //         await _scheduleRepository.WithDetailsAsync(z => z.Guide);

        //     //Apply additional LINQ extension methods
        //     var query = queryable.Where(x => x.IdTrip == IdTrip);

        //     //Execute the query and get the result
        //     var trip = await AsyncExecuter.ToListAsync(queryable);
        //     return trip;
        // }

        // [HttpPost("getTripSchedule")]
        // public Task<PagedResultDto<ScheduleDto>>
        // GetTripScheduleListAsync(ScheduleFilter input)
        // {
        //     return base.GetListAsync(input);
        // }
    }
}
