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
    EnumerationAppService
    :
    CrudAppService<Enumeration, //The Book entity
        EnumerationDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateEnumerationDto
    >, //Used to create/update a book
    IEnumerationAppService //implement the IBookAppService
    {
        public IRepository<Enumeration, Guid> _enumerationRepository;

        public EnumerationAppService(
            IRepository<Enumeration, Guid> repository
        ) :
            base(repository)
        {
            _enumerationRepository = repository;
        }

        [HttpGet("api/app/getEnumByType/{type}")]
        public async Task<List<Enumeration>>
        GetscheduledtripWithDetailsAsync(EnumType type)
        {
            //Get a IQueryable<T> by including sub collections
            var queryable = await _enumerationRepository.GetQueryableAsync();

            //Apply additional LINQ extension methods
            var query = queryable.Where(x => x.Type == type);

            //Execute the query and get the result
            var res = await AsyncExecuter.ToListAsync(query);
            return res;
        }
    }
}
