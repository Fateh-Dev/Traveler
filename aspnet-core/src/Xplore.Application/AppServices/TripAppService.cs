using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        [HttpGet("api/app/getTripWithDetails/{id}")]
        public async Task<TripWithDetailsDto> GetTripWithDetailsAsync(Guid id)
        {
            //Get a IQueryable<T> by including sub collections
            var queryable =
                await _tripRepository
                    .WithDetailsAsync(z => z.Locations,
                    e => e.Images,
                    s => s.ScheduledTrips,
                    k => k.PotentialClients,
                    b => b.Guide);

            //Apply additional LINQ extension methods
            var query = queryable.Where(x => x.Id == id);

            //Execute the query and get the result
            var trip = await AsyncExecuter.FirstOrDefaultAsync(query);
            TripWithDetailsDto TripDtoItem = ObjectMapper.Map<Trip, TripWithDetailsDto>(trip);

            string someUrl = "MyStaticFiles/";
            TripDtoItem.ActivitiesList=trip.Activities.Split("|");
            TripDtoItem.RisksList=trip.Risks.Split("|");
            TripDtoItem.RequiredStuffList=trip.RequiredStuff.Split("|");
            TripDtoItem.NotAllowedStuffList=trip.NotAllowedStuff.Split("|");
            TripDtoItem.NotSuitableForList=trip.NotSuitableFor.Split("|");
            TripDtoItem.LogingList=trip.Loging.Split("|");
            TripDtoItem.IncludedStuffList=trip.IncludedStuff.Split("|");

            using (var webClient = new WebClient())
            {
                TripDtoItem.ThumbnailImage =
                    webClient.DownloadData(someUrl + TripDtoItem.ThumbnailPic);
            }

            return TripDtoItem;
        }

        [HttpGet("api/app/GetHomeListAsync")]
        public async Task<List<TripMiniDto>> GetHomeListAsync(int cpt)
        {
            string someUrl = "MyStaticFiles/";

            //Obtain the IQueryable<Trip>
            IQueryable<Trip> queryable =
                await _tripRepository.GetQueryableAsync(); 
            var trips = queryable.PageBy(0, cpt).ToList(); 
            var MinTrips = new List<TripMiniDto>();

            // var count = 0;
            foreach (var item in trips)
            {
                // if (count >= cpt) break;
                var el = ObjectMapper.Map<Trip, TripMiniDto>(item);
                using (var webClient = new WebClient())
                {
                    el.ThumbnailImage =
                        webClient.DownloadData(someUrl + el.ThumbnailPic);
                }
                MinTrips.Add (el);
                // count++;
            }
            return MinTrips;
        }
    }
}
