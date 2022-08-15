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
            // string someUrl = "MyStaticFiles/";

            //Get a IQueryable<T> by including sub collections
            var queryable =
                await _guideRepository.WithDetailsAsync(z => z.Trips);

            //Apply additional LINQ extension methods
            var query = queryable.Where(x => x.Id == id);

            

            //Execute the query and get the result
            var res = await AsyncExecuter.FirstOrDefaultAsync(query);

            List<TripMiniDto> MinTrips =
                ObjectMapper.Map<List<Trip>, List<TripMiniDto>>(res.Trips.ToList());

            // foreach (var item in res.Trips)
            // {
            //     // if (count >= cpt) break;
            //     var el = ObjectMapper.Map<Trip, TripMiniDto>(item);
            //     using (var webClient = new WebClient())
            //     {
            //         // el.ThumbnailPic = "images/" + rnd.Next(1, 20) + ".jpg";
            //         el.ThumbnailImage =
            //             webClient.DownloadData(someUrl + el.ThumbnailPic);
            //     }
            //     MinTrips.Add (el);
            //     // count++;
            // }

            // res.Trips = (ICollection<Trip>) MinTrips;
            var guide = ObjectMapper.Map<Guide, GuideDto>(res);
            guide.Trips = MinTrips;
            return guide;
        }
    }
}
